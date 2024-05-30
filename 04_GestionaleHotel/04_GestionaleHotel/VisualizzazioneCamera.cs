using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_GestionaleHotel
{
    public partial class VisualizzazioneCamera : Form
    {
        private Camera? c;
        private GestioneDati g;
        private string? path = null;
        private string? fileName = null;
        public bool result = false;
        public VisualizzazioneCamera(Camera c, GestioneDati g, bool modifica = false)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.c = c;
            this.g = g;
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            lblFoto.Visible = false;
            if (!modifica)
            {
                txtID.Enabled = false;
                txtPosti.Enabled = false;
                txtCosto.Enabled = false;
                btnApplica.Visible = false;
                btnApplica.Enabled = false;
                btnAnnulla.Visible = false;
                btnAnnulla.Enabled = false;
                btnCarica.Visible = false;
                btnCarica.Enabled = false;
            }
            else
            {
                button1.Visible= false;
                button1.Enabled = false;
                txtID.Enabled = false;
            }
        }

        private void VisualizzazioneCamera_Load(object sender, EventArgs e)
        {
            if(c != null)
            {
                DisplayRoom();
            }
            else
            {
                NewRoom();
            }
        }
        private void DisplayRoom()
        {
            txtID.Text = c.ID.ToString();
            txtPosti.Text = c.Posti.ToString();
            double mediaRecensioni = c!.Voti.Count > 0 ? (c.Voti.Sum() / c.Voti.Count) : 0;
            lblRecensione.Text = c.Voti.Count != 0 ? (Math.Truncate(mediaRecensioni * 100) / 100).ToString() + " / 5" : "- / 5";
            label6.Text = "(" + c.Voti.Count.ToString() + ")";
            txtCosto.Text = c.Costo.ToString();

            if (!String.IsNullOrEmpty(c.Foto))
            {
                try
                {
                    pictureBoxCamera.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "Images/" + c.Foto));
                }
                catch (Exception ex)
                {
                    lblFoto.Visible = true;
                    lblFoto.Text = "Immagini non disponibili";
                }
            }
            else
            {
                lblFoto.Visible = true;
                lblFoto.Text = "Questa camera non ha immagini";
            }
        }
        private void NewRoom()
        {
            txtPosti.Enabled = true;
            txtCosto.Enabled = true;
            lblRecensione.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            btnCarica.Visible = true;
            btnCarica.Enabled = true;
            btnApplica.Visible = true;
            btnApplica.Enabled = true;
            btnAnnulla.Visible = true;
            btnAnnulla.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addrecensione recensione = new Addrecensione(c, g);
            recensione.ShowDialog();
            DisplayRoom();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplica_Click(object sender, EventArgs e)
        {
            if(c != null)
            {
                ApplyChangesToExistingCamera();
            }
            else
            {
                CreateNewCamera();
            }

        }
        private void ApplyChangesToExistingCamera()
        {
            try
            {
                int posti = Convert.ToInt32(txtPosti.Text);
                double costo = Convert.ToDouble(txtCosto.Text);
                costo = Math.Truncate(costo * 100) / 100;

                if (posti > 0)
                {
                    if (costo > 0)
                    {
                        c!.Posti = posti;
                        c!.Costo = costo;
                        if(path != null && fileName != null)
                        {
                            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
                            if (Directory.Exists(appPath))
                            {
                                string[] appo = fileName!.Split('.');
                                string nome = appo[0];
                                string estensione = appo[1];
                                string nomeFoto = nome + "." + estensione;
                                int i = 0;
                                while(File.Exists(appPath + nomeFoto))
                                {
                                    i++;
                                    nomeFoto = nome + "_" + i.ToString() + "." + estensione;
                                }
                                File.Copy(path!, appPath + nomeFoto);
                                c!.Foto = nomeFoto;
                            }
                        }

                        FormConferma conferma = new FormConferma();
                        conferma.ShowDialog();
                        if (conferma.ris)
                        {
                            string ris = g.AggiornaCamera(c!);
                            if (ris == "ok")
                            {
                                result = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(ris);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("'Costo' deve essere maggiore di 0");
                    }
                }
                else
                {
                    MessageBox.Show("'Posti' deve essere maggiore di 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateNewCamera()
        {
            try
            {
                int posti = Convert.ToInt32(txtPosti.Text);
                double costo = Convert.ToDouble(txtCosto.Text);
                costo = Math.Truncate(costo * 100) / 100;
                string? foto = null;
                if(posti > 0)
                {
                    if(costo > 0)
                    {
                        if(path != null && fileName != null)
                        {
                            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
                            if (Directory.Exists(appPath))
                            {
                                string[] appo = fileName!.Split('.');
                                string nome = appo[0];
                                string estensione = appo[1];
                                string nomeFoto = nome+"."+estensione;
                                int i = 0;
                                while(File.Exists(appPath + nomeFoto))
                                {
                                    i++;
                                    nomeFoto = nome + "_" + i.ToString() + "." + estensione;
                                }
                                File.Copy(path!, appPath + nomeFoto);
                                foto = nomeFoto;
                            }
                        }

                        FormConferma conferma = new FormConferma();
                        conferma.ShowDialog();
                        if (conferma.ris)
                        {
                            string ris = g.AggiungiCamera(posti, foto, costo);
                            if (ris == "ok")
                            {
                                result = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(ris);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("'Costo' deve essere maggiore di 0");
                    }
                }
                else
                {
                    MessageBox.Show("'Posti' deve essere maggiore di 0");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCarica_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Scegliere una foto";
                dlg.Filter = "Image Files(*.PNG;*.JPEG)|*.PNG;*.JPEG";

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxCamera.Image = Image.FromFile(dlg.FileName);
                    path = dlg.FileName;
                    fileName = dlg.SafeFileName;
                }
            }
        }
    }
}

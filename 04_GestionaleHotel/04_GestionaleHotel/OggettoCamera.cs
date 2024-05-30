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
    public partial class OggettoCamera : UserControl
    {
        private Camera c;
        private GestioneDati g;
        private FormCamere contenitore;
        public OggettoCamera(int sizeX, int sizeY, Camera c, GestioneDati g, FormCamere contenitore)
        {
            InitializeComponent();
            this.Size = new Size(sizeX, sizeY);
            this.Margin = new Padding(1, 1, 1, 1);
            this.c = c;
            this.g = g;
            this.contenitore = contenitore;
            pictureBox1.SizeMode= PictureBoxSizeMode.StretchImage;
        }

        private void OggettoCamera_Load(object sender, EventArgs e)
        {
            DisplayCAmera();
        }
        private void DisplayCAmera()
        {
            lblID.Text = "ID camera: " + c.ID.ToString();
            lblPosti.Text = "Posti disponibili: " + c.Posti.ToString();
            lblRecensione.Text = c.Voti.Count != 0 ? "Recensione: " + (c.Voti.Sum() / c.Voti.Count) : "Recensione: /";
            lblCosto.Text = "Costo (per notte): " + c.Costo.ToString();
            if (!String.IsNullOrEmpty(c.Foto))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "Images/" + c.Foto));
                }
                catch (Exception ex) { }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            VisualizzazioneCamera v = new VisualizzazioneCamera(c, g, true);
            v.ShowDialog();
            DisplayCAmera();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            FormConferma dialog = new FormConferma();
            dialog.ShowDialog();
            if (dialog.ris)
            {
                string ris = g.EliminaCamera(c.ID);
                if(ris == "ok")
                {
                    contenitore.DisplayRooms();
                }
                else
                {
                    MessageBox.Show(ris);
                }
            }
        }
    }
}

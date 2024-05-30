using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_GestionaleHotel
{
    public partial class VisualizzazionePrenotazione : Form
    {
        private Prenotazione? p;
        private GestioneDati g;
        private Camera? c;
        public bool result = false;
        public VisualizzazionePrenotazione(Prenotazione p, Camera c, GestioneDati g, DateTime? date, bool modify = false)
        {
            InitializeComponent();
            this.p = p;
            this.g = g;
            this.c = c;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            if(date != null)
            {
                DateTime day = (DateTime)date!;
                lblDay.Text = day.Day.ToString() + "/" + day.Month.ToString() + "/" + day.Year.ToString();
            }
            else
            {
                lblDay.Text = "";
            }

            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.CustomFormat = "dd-MM-yyyy";
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.CustomFormat = "dd-MM-yyyy";

            txtNumPersone.Text = "1";

            if(p != null)
            {
                DisplayPrenotazione(modify);
            }
            else
            {
                if(date != null)
                {
                    NewPrenotazione((DateTime)date!);
                }
                else
                {
                    NewPrenotazione(DateTime.Now.AddDays(1));
                }
            }
        }
        private void DisplayPrenotazione(bool modify)
        {
            if (!modify)
            {
                txtNumPersone.Enabled = false;
                cboTrattamento.Enabled = false;
                cboCliente.Enabled = false;
                cboCamere.Visible = false;
                dtpCheckIn.Enabled = false;
                dtpCheckOut.Enabled = false;

                btnAnnulla.Enabled = false;
                btnApplica.Enabled = false;
                btnAnnulla.Visible = false;
                btnApplica.Visible = false;
                cboCamere.Visible = false;

                btnAddCliente.Visible = false;
                btnAddCliente.Enabled = false;
            }
            else
            {
                List<Camera> camere = g.DammiCamere();
                cboCamere.DataSource = camere;
                cboCamere.SelectedItem = camere.FirstOrDefault(x => x.ID == p!.camera.ID);
            }
            lblPrenotazione.Text = "prenotazione " + p!.ID.ToString();

            dtpCheckIn.Value = p!.CheckIn;
            dtpCheckOut.Value = p!.CheckOut;

            lblGiorni.Text = (dtpCheckOut.Value - dtpCheckIn.Value).TotalDays.ToString() + " notti";

            lblID.Text = p!.ID.ToString();
            txtNumPersone.Text = p!.NumPersone.ToString();

            List<Trattamento> trattamenti = g.DammiTrattamenti();
            cboTrattamento.DataSource = trattamenti;
            cboTrattamento.SelectedItem = trattamenti.SingleOrDefault(x => x.Tipo == p!.IDTrattamento);
            lblTrattamento.Text = "(" + ((Trattamento)cboTrattamento.SelectedItem!).MoltiplicatoreCosto.ToString() + "x)";

            List<Cliente> clienti = g.DammiClienti();
            cboCliente.DataSource = clienti;
            cboCliente.SelectedItem = clienti.SingleOrDefault(x => x.ID == p!.IDCliente);

            btnCamera.Text = c!.ID.ToString();
            lblCamera.Text = "(" + c!.Costo + "€ / notte)";

            lblCosto.Text = p!.Costo.ToString() + " €";

        }
        private void NewPrenotazione(DateTime day)
        {
            lblPrenotazione.Text = "nuova prenotazione";

            lblID.Visible = false;
            lblCosto.Visible = false;
            lblTrattamento.Visible = false;
            lblCamera.Visible = true;

            dtpCheckIn.Value = day;
            dtpCheckIn.MinDate = day;
            dtpCheckOut.Value = day.AddDays(1);
            dtpCheckOut.MinDate = day.AddDays(1);

            lblGiorni.Text = (dtpCheckOut.Value - dtpCheckIn.Value).TotalDays.ToString() + " notti";

            cboTrattamento.DataSource = g.DammiTrattamenti();
            cboTrattamento.SelectedIndex = -1;
            cboCliente.DataSource = g.DammiClienti();
            cboCliente.SelectedIndex = -1;
            if(c != null)
            {
                cboCamere.Visible = false;
                btnCamera.Text = c.ID.ToString();
                lblCamera.Text = "(" + c!.Costo + "€ / notte)";
            }
            else
            {
                btnCamera.Text = "-";
                cboCamere.Visible = true;
                cboCamere.DataSource = g.DammiCamere();
                cboCamere.SelectedIndex = -1;
                lblCamera.Text = "";
            }
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            if(c!= null)
            {
                VisualizzazioneCamera v = new VisualizzazioneCamera(c, g);
                v.ShowDialog();
            }
        }

        private void btnApplica_Click(object sender, EventArgs e)
        {
            if(p != null)
            {
                ApplyModifiesToPrenotation();
            }
            else
            {
                CreateNewPrenotazione();
            }
        }
        private void ApplyModifiesToPrenotation()
        {
            try
            {
                int numPersone = Convert.ToInt32(txtNumPersone.Text);

                if (cboTrattamento.SelectedIndex != -1)
                {
                    if (cboCliente.SelectedIndex != -1)
                    {
                        if (c != null)
                        {
                            if (numPersone > 0 && numPersone <= c.Posti)
                            {
                                if (dtpCheckIn.Value.Ticks <= dtpCheckOut.Value.Ticks && (dtpCheckOut.Value - dtpCheckIn.Value).TotalDays >= 1)
                                {
                                    if (ControllaDAte(dtpCheckIn.Value, dtpCheckOut.Value))
                                    {
                                        Trattamento t = (Trattamento)cboTrattamento.SelectedItem;
                                        Cliente cli = (Cliente)cboCliente.SelectedItem;
                                        double costo = ((dtpCheckOut.Value - dtpCheckIn.Value).TotalDays * c.Costo) * t.MoltiplicatoreCosto;
                                        costo = Math.Truncate(costo * 100) / 100;
                                        //lblCosto.Text = costo.ToString() + " €";
                                        FormConferma conferma = new FormConferma(costo);
                                        conferma.ShowDialog();
                                        if (conferma.ris)
                                        {
                                            string ris = g.AggiornaPrenotazione(p.ID,dtpCheckIn.Value, dtpCheckOut.Value, numPersone, t.Tipo, cli.ID, c.ID);
                                            if (ris == "ok")
                                            {
                                                result = true;
                                                this.Close();
                                            }
                                            else { MessageBox.Show(ris); }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le date sono incompatibili con altre prenotazioni");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La data ti checkOut deve essere maggiore della data di checkIn");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Numero persone non appropriato");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inserire camera!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserire cliente!");
                    }
                }
                else
                {
                    MessageBox.Show("Inserire trattamento!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateNewPrenotazione()
        {
            try
            {
                int numPersone = Convert.ToInt32(txtNumPersone.Text);

                if (cboTrattamento.SelectedIndex != -1)
                {
                    if (cboCliente.SelectedIndex != -1)
                    {
                        if (c != null)
                        {
                            if(numPersone > 0 && numPersone <= c.Posti)
                            {
                                if (dtpCheckIn.Value.Ticks <= dtpCheckOut.Value.Ticks && (dtpCheckOut.Value - dtpCheckIn.Value).TotalDays >= 1)
                                {
                                    if (ControllaDAte(dtpCheckIn.Value, dtpCheckOut.Value))
                                    {
                                        Trattamento t = (Trattamento)cboTrattamento.SelectedItem;
                                        Cliente cli = (Cliente)cboCliente.SelectedItem;
                                        double costo = ((dtpCheckOut.Value - dtpCheckIn.Value).TotalDays * c.Costo) * t.MoltiplicatoreCosto;
                                        costo = Math.Truncate(costo * 100) / 100;
                                        //lblCosto.Text = costo.ToString() + " €";
                                        FormConferma conferma = new FormConferma(costo);
                                        conferma.ShowDialog();
                                        if (conferma.ris)
                                        {
                                            string ris = g.AggiungiPrenotazione(dtpCheckIn.Value, dtpCheckOut.Value, numPersone, t.Tipo, cli.ID, c.ID);
                                            if (ris == "ok")
                                            {
                                                result = true;
                                                this.Close();
                                            }
                                            else { MessageBox.Show(ris); }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le date sono incompatibili con altre prenotazioni");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La data ti checkOut deve essere maggiore della data di checkIn");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Numero persone non appropriato");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inserire camera!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inserire cliente!");
                    }
                }
                else
                {
                    MessageBox.Show("Inserire trattamento!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool ControllaDAte(DateTime checkIn, DateTime checkOut)
        {
            List<Prenotazione> prenotazioni = g.DammiPrenotazioniCamera(c!);

            bool ris = true;
            
            if(p != null)
            {
                foreach (Prenotazione pr in prenotazioni)
                {
                    if(pr.ID != p.ID)
                    {
                        if ((checkIn.Ticks < pr.CheckIn.Ticks && checkOut.Ticks < pr.CheckIn.Ticks) ||
                        (checkIn.Ticks > pr.CheckOut.Ticks && checkOut.Ticks > pr.CheckOut.Ticks))
                        {
                            ris = true;
                        }
                        else
                        {
                            ris = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Prenotazione p in prenotazioni)
                {
                    if ((checkIn.Ticks < p.CheckIn.Ticks && checkOut.Ticks < p.CheckIn.Ticks) ||
                        (checkIn.Ticks > p.CheckOut.Ticks && checkOut.Ticks > p.CheckOut.Ticks))
                    {
                        ris = true;
                    }
                    else
                    {
                        ris = false;
                        break;
                    }
                }
            }

            return ris;
        }
        private void cboTrattamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrattamento.SelectedItem != null)
            {
                lblTrattamento.Visible = true;
                lblTrattamento.Text = "(" + ((Trattamento)cboTrattamento.SelectedItem).MoltiplicatoreCosto.ToString() + "x)";
            }
            else
            {
                lblTrattamento.Visible = false;
            }

        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if(dtpCheckIn.Value.Ticks < dtpCheckOut.Value.Ticks)
            {
                lblGiorni.Text = (dtpCheckOut.Value - dtpCheckIn.Value).TotalDays.ToString() + " notti";
            }
            else
            {
                lblGiorni.Text = "/ notti";
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value.Ticks < dtpCheckOut.Value.Ticks)
            {
                lblGiorni.Text = (dtpCheckOut.Value - dtpCheckIn.Value).TotalDays.ToString() + " notti";
            }
            else
            {
                lblGiorni.Text = "/ notti";
            }
        }

        private void cboTrattamento_TextChanged(object sender, EventArgs e)
        {
            if(cboTrattamento.SelectedIndex == -1)
            {
                lblTrattamento.Visible = false;
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCamere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCamere.SelectedIndex != -1)
            {
                c = (Camera)cboCamere.SelectedItem;
                btnCamera.Text = c.ID.ToString();
                lblCamera.Text = "(" + c.Costo + "€ / notte)";
            }
            else
            {
                c = null;
                btnCamera.Text = "-";
                lblCamera.Text = "";
            }
        }

        private void cboCamere_TextChanged(object sender, EventArgs e)
        {
            if (cboCamere.SelectedIndex != -1)
            {
                c = (Camera)cboCamere.SelectedItem;
                btnCamera.Text = c.ID.ToString();
                lblCamera.Text = "(" + c.Costo + "€ / notte)";
            }
            else
            {
                c = null;
                btnCamera.Text = "-";
                lblCamera.Text = "";
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            VisualizzazioneCliente v = new VisualizzazioneCliente(g, null);
            v.ShowDialog();
            if (v.ris)
            {
                cboCliente.DataSource = g.DammiClienti();
            }
        }
    }
}

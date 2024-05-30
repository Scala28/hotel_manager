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
    public partial class VisualizzazioneTrattamento : Form
    {
        private GestioneDati g;
        private Trattamento? t;
        public bool result = false;
        public VisualizzazioneTrattamento(Trattamento? t, GestioneDati g)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox= false;
            this.t = t;
            this.g = g;
            if(t != null )
            {
                DisplayTrattamento();
            }
            else
            {
                NewTrattamento();
            }
        }

        private void DisplayTrattamento()
        {
            lblOperazione.Text = "Modifica trattamento";
            txtTipo.Text = t!.Tipo;
            txtTipo.Enabled = false;
            txtMoltiplicatore.Text = t!.MoltiplicatoreCosto.ToString();
        }
        private void NewTrattamento()
        {
            lblOperazione.Text = "Nuovo trattamento";
        }

        private void btnApplica_Click(object sender, EventArgs e)
        {
            if(t != null)
            {
                ModifyTrattamento();
            }
            else
            {
                CreateTrattamento();
            }
        }
        private void ModifyTrattamento()
        {
            if (!String.IsNullOrEmpty(txtMoltiplicatore.Text))
            {
                try
                {
                    double moltiplicatoreCosto = Convert.ToDouble(txtMoltiplicatore.Text);
                    moltiplicatoreCosto = Math.Truncate(moltiplicatoreCosto * 100) / 100;

                    FormConferma conferma = new FormConferma();
                    conferma.ShowDialog();
                    if (conferma.ris)
                    {
                        string ris = g.ModificaTrattamento(t!.Tipo, txtTipo.Text, moltiplicatoreCosto);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Moltiplicatore costo obbligatorio");
            }
        }
        private void CreateTrattamento()
        {
            if (!String.IsNullOrEmpty(txtTipo.Text))
            {
                if (!String.IsNullOrEmpty(txtMoltiplicatore.Text))
                {
                    try
                    {
                        double moltiplicatoreCosto = Convert.ToDouble(txtMoltiplicatore.Text);
                        moltiplicatoreCosto = Math.Truncate(moltiplicatoreCosto * 100) / 100;

                        FormConferma conferma = new FormConferma();
                        conferma.ShowDialog();
                        if (conferma.ris)
                        {
                            string ris = g.AggiungiTrattamento(txtTipo.Text, moltiplicatoreCosto);
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Moltiplicatore costo obbligatorio");
                }
            }
            else
            {
                MessageBox.Show("Nome trattamento obbligatorio");
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}

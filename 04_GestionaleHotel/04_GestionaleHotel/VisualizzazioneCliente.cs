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
    public partial class VisualizzazioneCliente : Form
    {
        private GestioneDati g;
        private Cliente? c;
        public bool ris = false;
        public VisualizzazioneCliente(GestioneDati g, Cliente? c)
        {
            InitializeComponent();
            this.g = g;
            this.c = c;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            if(c != null )
            {
                DisplayCliente();
            }
            else
            {
                NewCliente();
            }

        }
        private void DisplayCliente()
        {
            lblOperazione.Text = "Modifica cliente";

            lblID.Text = c!.ID.ToString();
            txtNome.Text = c!.Nome;
            txtCognome.Text = c!.Cognome;

            txtNumero.Text = c!.Telefono;
            txtEmail.Text = c!.email;
        }
        private void NewCliente()
        {
            lblOperazione.Text = "Nuovo cliente";

            lblID.Text = "";
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            ris = false;
            this.Close();
        }

        private void btnApplica_Click(object sender, EventArgs e)
        {
            if(c != null)
            {
                ModifyCliente();
            }
            else
            {
                CreateCliente();
            }
        }
        private void ModifyCliente()
        {
            bool ok = true;
            if(!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtCognome.Text))
            {
                string Nome = txtNome.Text;
                string Cognome = txtCognome.Text;
                string? tel = null;
                string? email = null;
                if (!String.IsNullOrEmpty(txtNumero.Text))
                {
                    string numText = txtNumero.Text.Replace(" ", String.Empty);
                    if (numText.Length == 10) {
                        try
                        {
                            long appo = Convert.ToInt64(numText);
                            tel = numText;
                        }
                        catch (Exception ex)
                        {
                            ok = false;
                            MessageBox.Show("Numero di telefono non valido");
                        }
                    }
                    else
                    {
                        ok = false;
                        MessageBox.Show("Numero di telefono non valido");
                    }
                }
                if (!String.IsNullOrEmpty(txtEmail.Text))
                {
                    if (txtEmail.Text.Contains('@'))
                    {
                        email = txtEmail.Text;
                    }
                    else
                    {
                        ok = false;
                        MessageBox.Show("Indirizzo e-mail non valido");
                    }
                }

                if (ok)
                {
                    FormConferma conferma = new FormConferma();
                    conferma.ShowDialog();
                    if (conferma.ris)
                    {
                        ris = true;
                        string result = g.AggiornaCliente(c.ID, Nome, Cognome, tel, email);
                        if (result == "ok")
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(result);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Inserire i dati obbligatori 'Nome' e 'Cognome'");
            }
        }
        private void CreateCliente()
        {
            bool ok = true;
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtCognome.Text))
            {
                string Nome = txtNome.Text;
                string Cognome = txtCognome.Text;
                string? tel = null;
                string? email = null;
                if (!String.IsNullOrEmpty(txtNumero.Text))
                {
                    string numText = txtNumero.Text.Replace(" ", String.Empty);
                    if (numText.Length == 10)
                    {
                        try
                        {
                            long appo = Convert.ToInt64(numText);
                            tel = numText;
                        }
                        catch (Exception ex)
                        {
                            ok = false;
                            MessageBox.Show("Numero di telefono non valido");
                        }
                    }
                    else
                    {
                        ok = false;
                        MessageBox.Show("Numero di telefono non valido");
                    }
                }
                if (!String.IsNullOrEmpty(txtEmail.Text))
                {
                    if (txtEmail.Text.Contains('@'))
                    {
                        email = txtEmail.Text;
                    }
                    else
                    {
                        ok = false;
                        MessageBox.Show("Indirizzo e-mail non valido");
                    }
                }

                if (ok)
                {
                    FormConferma conferma = new FormConferma();
                    conferma.ShowDialog();
                    if (conferma.ris)
                    {
                        ris = true;
                        string result = g.AggiungiCliente(Nome, Cognome, tel, email);
                        if (result == "ok")
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(result);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Inserire i dati obbligatori 'Nome' e 'Cognome'");
            }
        }
    }
}

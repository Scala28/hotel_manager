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
    public partial class Addrecensione : Form
    {
        private Camera c;
        private GestioneDati g;
        public Addrecensione(Camera c, GestioneDati g)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.c = c;
            this.g = g;
        }

        private void Addrecensione_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Nuova valutazione per camera " + c.ID.ToString();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            try
            {
                double voto = Convert.ToDouble(txtVoto.Text);
                if(voto >= 0 && voto <= 5)
                {
                    voto = Math.Truncate(voto * 100) / 100;
                    c.Voti.Add(voto);
                    string ris = g.AggiungiRecensione(c, voto);
                    if(ris == "ok")
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(ris);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("valutazione compresa tra 0 e 5!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

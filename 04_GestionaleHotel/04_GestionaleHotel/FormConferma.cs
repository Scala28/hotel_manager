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
    public partial class FormConferma : Form
    {
        public bool ris;
        public FormConferma(double p = -1)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox= false;
            ris = false;

            if(p != -1)
            {
                label1.Text = "Totale: " + p.ToString() + " €";
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            ris = true;
            this.Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormClienti : Form
    {
        private GestioneDati g;
        private List<Cliente> clienti;
        public FormClienti(GestioneDati g)
        {
            InitializeComponent();
            this.g = g;
            clienti = new List<Cliente>();
            DisplayClienti(g.DammiClienti());
        }

        private void DisplayClienti(List<Cliente> cs)
        {
            clienti = cs;
            tabellaClienti.DataSource = cs;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int index = tabellaClienti.CurrentRow.Index;
            if(index != -1 )
            {
                Cliente c = clienti[index];
                VisualizzazioneCliente v = new VisualizzazioneCliente(g, c);
                v.ShowDialog();
                if (v.ris)
                {
                    DisplayClienti(g.DammiClienti());
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            VisualizzazioneCliente v = new VisualizzazioneCliente(g, null);
            v.ShowDialog();
            if (v.ris)
            {
                DisplayClienti(g.DammiClienti());
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int index = tabellaClienti.CurrentRow.Index;
            if(index != -1 )
            {
                Cliente c = clienti[index];
                FormConferma conferma = new FormConferma();
                conferma.ShowDialog();
                if (conferma.ris)
                {
                    string ris = g.RemoveCliente(c.ID);
                    if(ris == "ok")
                    {
                        DisplayClienti(g.DammiClienti());
                    }
                    else
                    {
                        MessageBox.Show(ris);
                    }
                }
                
            }
        }

        private void tabellaClienti_SelectionChanged(object sender, EventArgs e)
        {
            if(tabellaClienti.SelectedRows.Count == 0)
            {
                btnElimina.Enabled = false;
                btnModifica.Enabled = false;
            }
            else
            {
                btnElimina.Enabled = true;
                btnModifica.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_GestionaleHotel
{
    public partial class FormTrattamenti : Form
    {
        private GestioneDati g;
        private List<Trattamento> trattamenti;
        public FormTrattamenti(GestioneDati g)
        {
            InitializeComponent();
            this.g = g;
            trattamenti = new List<Trattamento>();
            DisplayTrattamenti(g.DammiTrattamenti());
        }
        private void DisplayTrattamenti(List<Trattamento> ts)
        {
            trattamenti = ts;
            tabellaTrattamenti.DataSource = trattamenti;
        }

        private void tabellaTrattamenti_SelectionChanged(object sender, EventArgs e)
        {
            if(tabellaTrattamenti.SelectedRows.Count > 0)
            {
                btnElimina.Enabled = true;
                btnModifica.Enabled = true;
            }
            else
            {
                btnElimina.Enabled = false;
                btnModifica.Enabled = false;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int index = tabellaTrattamenti.CurrentRow.Index;
            if(index != -1 )
            {
                Trattamento t = trattamenti[index];
                VisualizzazioneTrattamento v = new VisualizzazioneTrattamento(t, g);
                v.ShowDialog();
                if (v.result)
                {
                    DisplayTrattamenti(g.DammiTrattamenti());
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            VisualizzazioneTrattamento v = new VisualizzazioneTrattamento(null, g);
            v.ShowDialog();
            if (v.result)
            {
                DisplayTrattamenti(g.DammiTrattamenti());
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int index = tabellaTrattamenti.CurrentRow.Index;
            if(index != -1 )
            {
                Trattamento t = trattamenti[index];
                FormConferma conferma = new FormConferma();
                conferma.ShowDialog();
                if (conferma.ris)
                {
                    string ris = g.EliminaTrattamento(t.Tipo);
                    if(ris == "ok")
                    {
                        DisplayTrattamenti(g.DammiTrattamenti());
                    }
                    else
                    {
                        MessageBox.Show(ris);
                    }
                }
            }
        }
    }
}

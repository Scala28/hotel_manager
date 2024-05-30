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
    public partial class FormPrenotazioni : Form
    {
        private GestioneDati g;
        private List<Prenotazione> prenotazioni;
        private bool sideBarExpand = false;
        const int maximumWidth = 405;
        const int minimumWidth = 85;
        public FormPrenotazioni(GestioneDati g)
        {
            InitializeComponent();
            this.g = g;
            prenotazioni = new List<Prenotazione>();
            InitializeFilters();
            DisplayPrenotazioni(g.DammiPrenotazioni());
        }
        private void InitializeFilters()
        {
            sideBar.Width = minimumWidth;
            gbFilters.Visible = false;

            cboClienti.DataSource = g.DammiClienti();
            cboClienti.SelectedIndex = -1;
            cboCamere.DataSource = g.DammiCamere();
            cboCamere.SelectedIndex = -1;
            cboTrattamento.DataSource = g.DammiTrattamenti();
            cboTrattamento.SelectedIndex = -1;

            dtpFilter.Format = DateTimePickerFormat.Custom;
            dtpFilter.CustomFormat = " ";
            dtpFilter.Checked = false;
            
        }
        private void DisplayPrenotazioni(List<Prenotazione> ps)
        {
            dgwPrenotazioni.Rows.Clear();
            prenotazioni = ps;
            foreach(Prenotazione p in prenotazioni)
            {
                dgwPrenotazioni.Rows.Add(new object[]
                {
                    p.ID,
                    p.CheckIn.Day +"/"+p.CheckIn.Month+"/"+p.CheckIn.Year,
                    p.CheckOut.Day +"/"+p.CheckOut.Month+"/"+p.CheckOut.Year,
                    p.NumPersone,
                    p.IDTrattamento,
                    p.IDCliente,
                    p.IDCamera,
                    p.Costo
                });
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            VisualizzazionePrenotazione v = new VisualizzazionePrenotazione(null, null, g, null);
            v.ShowDialog();
            if (v.result)
            {
                Reset();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            int index = dgwPrenotazioni.CurrentCell.RowIndex;
            if(index != -1)
            {
                Prenotazione p = prenotazioni[index];
                VisualizzazionePrenotazione v = new VisualizzazionePrenotazione(p, p.camera, g, null, true);
                v.ShowDialog();
                if (v.result)
                {
                    Reset();
                }
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int index = dgwPrenotazioni.CurrentRow.Index;
            if(index != -1)
            {
                FormConferma conferma = new FormConferma();
                conferma.ShowDialog();
                if (conferma.ris)
                {
                    Prenotazione p = prenotazioni[index];
                    string ris = g.DeletePrenotazione(p.ID);
                    if (ris == "ok")
                    {
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show(ris);
                    }
                }
            }
        }
        private void dgwPrenotazioni_SelectionChanged(object sender, EventArgs e)
        {
            if(dgwPrenotazioni.SelectedRows.Count == 0)
            {
                btnModifica.Enabled = false;
                btnElimina.Enabled = false;
            }
            else
            {
                btnModifica.Enabled = true;
                btnElimina.Enabled = true;
            }
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if(sideBar.Width == minimumWidth)
                {
                    sideBarTimer.Stop();
                    sideBarExpand = false;
                    gbFilters.Visible = false;
                }
            }
            else
            {
                sideBar.Width += 10;
                if(sideBar.Width == maximumWidth)
                {
                    sideBarTimer.Stop();
                    sideBarExpand = true;
                    gbFilters.Visible = true;
                }
            }
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            List<Prenotazione> ris = g.DammiPrenotazioni();
            
            if(cboClienti.SelectedIndex != -1)
            {
                Cliente c = (Cliente)cboClienti.SelectedItem;
                ris = ris.Where(x => x.IDCliente == c.ID).ToList();
            }
            if(cboCamere.SelectedIndex != -1)
            {
                Camera c = (Camera)cboCamere.SelectedItem;
                ris = ris.Where(x => x.IDCamera == c.ID).ToList();
            }
            if(cboTrattamento.SelectedIndex != -1)
            {
                Trattamento t = (Trattamento)cboTrattamento.SelectedItem;
                ris = ris.Where(x => x.IDTrattamento == t.Tipo).ToList();
            }
            if(dtpFilter.Checked)
            {
                int month = dtpFilter.Value.Month;
                int year = dtpFilter.Value.Year;
                ris = ris.Where(x => x.CheckIn.Month == month && x.CheckIn.Year == year).ToList();
            }

            DisplayPrenotazioni(ris);
        }

        private void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            dtpFilter.CustomFormat = "MMMM/yyyy";
            dtpFilter.ShowUpDown = true;
            dtpFilter.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpFilter.CustomFormat = " ";
            dtpFilter.ShowUpDown = false;
            dtpFilter.Checked = false;
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            cboClienti.SelectedIndex = -1;
            cboClienti.Text = string.Empty;
            cboCamere.SelectedIndex = -1;
            cboCamere.Text = string.Empty;
            cboTrattamento.SelectedIndex = -1;
            cboTrattamento.Text = string.Empty;

            dtpFilter.CustomFormat = " ";
            dtpFilter.ShowUpDown = false;
            dtpFilter.Checked = false;

            DisplayPrenotazioni(g.DammiPrenotazioni());
        }
    }
}

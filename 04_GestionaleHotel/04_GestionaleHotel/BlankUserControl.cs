using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_GestionaleHotel
{
    public partial class BlankUserControl : UserControl
    {
        private Prenotazione? p;
        private GestioneDati g;
        private Camera c;
        private DateTime day;
        private Form1 displayer;
        public BlankUserControl(int sizeX, int sizeY, DateTime day, Camera c, GestioneDati g, Form1 displayer)
        {
            InitializeComponent();
            this.Size = new Size(sizeX, sizeY);
            this.Margin = new Padding(1, 1, 1, 1);
            this.g = g;
            this.c = c;
            this.day = day;
            this.displayer = displayer;
            List<Prenotazione> prenotazioni = g.DammiPrenotazioniCamera(c);

            for (int i = 0; i < prenotazioni.Count; i++)
            {
                if (day.Ticks >= prenotazioni[i].CheckIn.Ticks && day.Ticks <= prenotazioni[i].CheckOut.Ticks)
                {
                    p = prenotazioni[i];
                    break;
                }
            }
            if (p != null)
            {
                btnPrenotazione.BackColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                btnPrenotazione.BackColor = Color.White;
                if (day.Ticks < DateTime.Now.Ticks)
                {
                    btnPrenotazione.Enabled = false;
                }
            }

        }

        private void btnPrenotazione_Click(object sender, EventArgs e)
        {
            VisualizzazionePrenotazione prenotazione = new VisualizzazionePrenotazione(p, c, g, day);
            prenotazione.ShowDialog();
            if (prenotazione.result)
            {
                displayer.Display();
            }
        }
    }
}

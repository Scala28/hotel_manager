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
    public partial class FormCamere : Form
    {
        private GestioneDati g;

        const int minSizeY = 210;
        public FormCamere(GestioneDati g)
        {
            InitializeComponent();
            this.g = g;

            roomContainer.FlowDirection = FlowDirection.TopDown;
            roomContainer.WrapContents = false;
            roomContainer.AutoScroll = true;
        }
        public void DisplayRooms()
        {
            roomContainer.Controls.Clear();
            List<Camera> camere = g.DammiCamere();

            int sizeX = roomContainer.ClientSize.Width - 2;
            int sizeY = (roomContainer.ClientSize.Height - camere.Count * 2) / camere.Count;
            if(sizeY < minSizeY)
            {
                sizeY = minSizeY;
                sizeX = roomContainer.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 2;
            }

            for(int i=0; i<camere.Count; i++)
            {
                Camera c = camere[i];

                OggettoCamera room = new OggettoCamera(sizeX, sizeY, c, g, this);
                roomContainer.Controls.Add(room);
            }
        }

        private void FormCamere_Shown(object sender, EventArgs e)
        {
            DisplayRooms();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            VisualizzazioneCamera v = new VisualizzazioneCamera(null, g);
            v.ShowDialog();
            if (v.result)
            {
                DisplayRooms();
            }
        }
        public void Display()
        {
            DisplayRooms();
        }
    }
}

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
    public partial class Room : UserControl
    {
        private Camera c;
        private GestioneDati g;
        public Room(int sizeX, int sizeY, Camera c, GestioneDati g)
        {
            InitializeComponent();
            this.Size = new Size(sizeX, sizeY);
            this.Margin = new Padding(1, 1, 1, 1);
            this.c = c;
            this.g = g;
            btnCamera.Text = c.ID.ToString();

        }

        private void btnCamera_Click(object sender, EventArgs e)
        {
            VisualizzazioneCamera camera = new VisualizzazioneCamera(c, g);
            camera.ShowDialog();
        }
    }
}

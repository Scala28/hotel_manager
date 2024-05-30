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
    public partial class Day : UserControl
    {
        public Day(int sizeX, int sizeY, DateTime dayNumber)
        {
            InitializeComponent();
            this.Size = new Size(sizeX, sizeY);
            this.Margin = new Padding(1, 1, 1, 1);
            lblDay.Text = dayNumber.Day.ToString();
            if(dayNumber.Ticks >= DateTime.Now.Ticks)
            {
                lblDay.BackColor = Color.FromArgb(255, 128, 255);
            }
        }
    }
}

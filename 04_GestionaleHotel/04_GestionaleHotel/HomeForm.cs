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
    public partial class HomeForm : Form
    {
        private GestioneDati g;

        private Form activeForm;
        public HomeForm()
        {
            InitializeComponent();
            g = new GestioneDati();
            LastSize = this.Size;
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm!= null) { activeForm.Close(); }
            activeForm= childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel= false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            openChildForm(new Form1(g));
        }

        private void btnTabella_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1(g));
        }
        private void btnCamere_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCamere(g));
        }

        private void btnPrenotazioni_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrenotazioni(g));
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClienti(g));
        }
        private void btnTrattamenti_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTrattamenti(g));
        }

        private FormWindowState LastWindowState = FormWindowState.Normal;
        private void HomeForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState != LastWindowState)
            {
                LastWindowState = this.WindowState;

                if(activeForm is FormCamere)
                {
                    (activeForm as FormCamere).Display();
                }else if(activeForm is Form1)
                {
                    (activeForm as Form1).Display();
                }
            }
        }

        private Size LastSize;
        private void HomeForm_ResizeEnd(object sender, EventArgs e)
        {
            if(this.Size != LastSize)
            {
                LastSize = this.Size;

                if (activeForm is FormCamere)
                {
                    (activeForm as FormCamere).Display();
                }
                else if (activeForm is Form1)
                {
                    (activeForm as Form1).Display();
                }
            }
        }

    }
}

using System.Globalization;
using System.Security.Cryptography;
using System.Reflection;
using System.Drawing.Design;
using System.Diagnostics;

namespace _04_GestionaleHotel
{
    public partial class Form1 : Form
    {
        GestioneDati g;

        const int minCellSizeX = 80;
        const int minCellSizeY = 60;

        MyFlowLayoutPanel container;
        MyFlowLayoutPanel dayCounter;
        MyFlowLayoutPanel roomContainer;

        private int dayHeight, roomWidth;

        int month, year;
        public Form1(GestioneDati g)
        {
            InitializeComponent();
            this.g = g;
            InitializeContainers();

            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
        }

        private void InitializeContainers()
        {
            dayHeight = label1.Size.Height;
            roomWidth = label1.Size.Width;

            //panel1.BringToFront();

            panel1.Size = new Size(panel4.Width - roomWidth, panel4.Height - dayHeight);
            panel1.Anchor = AnchorStyles.Top
                | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Size = new Size(panel4.Width - roomWidth, dayHeight);
            panel2.Anchor = AnchorStyles.Left
                | AnchorStyles.Right | AnchorStyles.Top;
            panel3.Size = new Size(roomWidth, panel4.Height - dayHeight);
            panel3.Anchor = AnchorStyles.Left
                | AnchorStyles.Top | AnchorStyles.Bottom;

            container = new MyFlowLayoutPanel();
            //container.Dock = DockStyle.Fill;
            container.BackColor = Color.FromArgb(0, 64, 64);
            container.Parent = panel1;
            container.Location = new Point(0, 0);
            container.Width = panel1.ClientSize.Width;
            container.Height = panel1.ClientSize.Height;
            container.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            container.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            container.WrapContents = false;
            container.AutoScroll = true;
            container.MouseWheel += container_MouseWheel;

            dayCounter = new MyFlowLayoutPanel();
            //dayCounter.Dock = DockStyle.Fill;
            dayCounter.BackColor = Color.FromArgb(0, 64, 64);
            dayCounter.Parent = panel2;
            dayCounter.Location = new Point(0, 0);
            dayCounter.Width = panel2.ClientSize.Width;
            dayCounter.Height = panel2.ClientSize.Height + SystemInformation.HorizontalScrollBarHeight;
            dayCounter.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            dayCounter.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            dayCounter.WrapContents = false;
            dayCounter.AutoScroll = true;
            dayCounter.MouseWheel += dayCounter_MouseWheel;

            roomContainer = new MyFlowLayoutPanel();
            //roomContainer.Dock = DockStyle.Fill;
            roomContainer.BackColor = Color.FromArgb(0, 64, 64);
            roomContainer.Parent = panel3;
            roomContainer.Location = new Point(0, 0);
            roomContainer.Width = panel3.ClientSize.Width;
            roomContainer.Height = panel3.ClientSize.Height;
            roomContainer.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            roomContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            roomContainer.WrapContents = false;
            roomContainer.AutoScroll = true;
            roomContainer.MouseWheel += roomContainer_MouseWheel;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //DisplayTable();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            DisplayCalendar(new DateTime(year, month, 1));
            DisplayTable();
        }
        public void Display()
        {
            DisplayCalendar(new DateTime(year, month, 1));
            DisplayTable();
        }

        private void DisplayCalendar(DateTime t)
        {
            container.Controls.Clear();
            roomContainer.Controls.Clear();
            dayCounter.Controls.Clear();
            container.WrapContents = false;
            int daysInMonth = DateTime.DaysInMonth(t.Year, t.Month);
            List<Camera> camere = g.DammiCamere();
            int nCamere = camere.Count;

            lblDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year.ToString();

            int availableY = panel1.Height;
            int availableX = panel1.Width;

            int sizeX = (availableX / daysInMonth) >= minCellSizeX ? (availableX / daysInMonth) : minCellSizeX;
            int sizeY = nCamere > 0 && ((availableY / nCamere) - 2 >= minCellSizeY) ? (availableY / nCamere) - 2 : minCellSizeY;

            for (int i = 1; i <= daysInMonth; i++)
            {
                Day day = new Day(sizeX, panel2.Height - 2, new DateTime(year, month, i));
                dayCounter.Controls.Add(day);
            }

            for (int j = 0; j < nCamere; j++)
            {
                Camera c = camere[j];
                Room room = new Room(panel3.Width - 2, sizeY, c, g);
                roomContainer.Controls.Add(room);
                for (int i = 1; i <= daysInMonth; i++)
                {
                    BlankUserControl uc = new BlankUserControl(sizeX, sizeY, new DateTime(t.Year, t.Month, i), c, g, this);
                    container.Controls.Add(uc);
                }
                if (j == 0) { container.WrapContents = true; }
            }
        }

        private void DisplayTable()
        {
            if (container.HorizontalScroll.Visible)
            {
                container.Height = panel1.ClientSize.Height + SystemInformation.HorizontalScrollBarHeight;
                hScrollBar1.Visible = true;
                hScrollBar1.Maximum = container.HorizontalScroll.Maximum;
                hScrollBar1.Minimum = container.HorizontalScroll.Minimum;
                hScrollBar1.SmallChange = container.HorizontalScroll.SmallChange;
                hScrollBar1.LargeChange = container.HorizontalScroll.LargeChange;
                SynchronizeHorizontalScroll(0);
            }
            else
            {
                container.Height = panel1.ClientSize.Height;
                hScrollBar1.Visible = false;
            }

            Debug.Print(container.VerticalScroll.Visible.ToString());
            Debug.Print(container.VerticalScroll.Enabled.ToString());
            if (container.VerticalScroll.Visible)
            {
                container.Width = panel1.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
                roomContainer.Width = panel3.ClientSize.Width + SystemInformation.VerticalScrollBarWidth;
                vScrollBar1.Visible = true;
                vScrollBar1.Maximum = container.VerticalScroll.Maximum;
                vScrollBar1.Minimum = container.VerticalScroll.Minimum;
                vScrollBar1.SmallChange = container.VerticalScroll.SmallChange;
                vScrollBar1.LargeChange = container.VerticalScroll.LargeChange;
                SynchronizeVerticalScroll(0);
            }
            else
            {
                container.Width = panel1.ClientSize.Width;
                roomContainer.Width = panel3.ClientSize.Width;
                vScrollBar1.Visible = false;
            }
        }

        private void SynchronizeVerticalScroll(int value)
        {
            container.VerticalScroll.Value = value;
            roomContainer.VerticalScroll.Value = value;
            vScrollBar1.Value = value;
        }
        private void SynchronizeHorizontalScroll(int value)
        {
            container.HorizontalScroll.Value = value;
            dayCounter.HorizontalScroll.Value = value;
            hScrollBar1.Value = value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SynchronizeHorizontalScroll(e.NewValue);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            SynchronizeVerticalScroll(e.NewValue);
        }

        private void container_MouseWheel(object sender, MouseEventArgs e)
        {
            SynchronizeVerticalScroll(container.VerticalScroll.Value);
            SynchronizeHorizontalScroll(container.HorizontalScroll.Value);
        }

        private void roomContainer_MouseWheel(object sender, MouseEventArgs e)
        {
            SynchronizeVerticalScroll(roomContainer.VerticalScroll.Value);
        }
        private void dayCounter_MouseWheel(object sender, MouseEventArgs e)
        {
            SynchronizeHorizontalScroll(dayCounter.HorizontalScroll.Value);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            DisplayCalendar(new DateTime(year, month, 1));
            DisplayTable();
        }


        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            container.Controls.Clear();
            dayCounter.Controls.Clear();
            roomContainer.Controls.Clear();
            DisplayCalendar(new DateTime(year, month, 1));
            DisplayTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
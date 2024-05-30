using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_GestionaleHotel
{
    public class MyFlowLayoutPanel: FlowLayoutPanel
    {
        public MyFlowLayoutPanel() : base()
        {
            this.DoubleBuffered = true;
            //this.SetStyle(ControlStyles.UserPaint |
            //    ControlStyles.OptimizedDoubleBuffer |
            //    ControlStyles.AllPaintingInWmPaint, true);
            //this.UpdateStyles();
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            this.SuspendLayout();
            base.OnControlAdded(e);
            this.ResumeLayout();
        }
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            this.SuspendLayout();
            base.OnControlRemoved(e);
            this.ResumeLayout();
        }
        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();
            base.OnScroll(se);
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
    }
}

namespace _04_GestionaleHotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            panel4 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            lblDate = new Label();
            btnNextMonth = new Button();
            btnPreviousMonth = new Button();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vScrollBar1.Location = new Point(1729, 228);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(21, 817);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hScrollBar1.Location = new Point(238, 1052);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(1486, 22);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(52, 143);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(1671, 902);
            panel4.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(186, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1486, 85);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 85);
            label1.TabIndex = 4;
            label1.Text = "Rooms";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(186, 85);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 817);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 85);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 817);
            panel3.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(258, 26);
            lblDate.Margin = new Padding(6, 0, 6, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(533, 85);
            lblDate.TabIndex = 8;
            lblDate.Text = "MONTH YEAR";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNextMonth.Location = new Point(734, 26);
            btnNextMonth.Margin = new Padding(6);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(74, 85);
            btnNextMonth.TabIndex = 9;
            btnNextMonth.Text = ">";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click;
            // 
            // btnPreviousMonth
            // 
            btnPreviousMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPreviousMonth.Location = new Point(238, 26);
            btnPreviousMonth.Margin = new Padding(6);
            btnPreviousMonth.Name = "btnPreviousMonth";
            btnPreviousMonth.Size = new Size(74, 85);
            btnPreviousMonth.TabIndex = 10;
            btnPreviousMonth.Text = "<";
            btnPreviousMonth.UseVisualStyleBackColor = true;
            btnPreviousMonth.Click += btnPreviousMonth_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1805, 1129);
            Controls.Add(panel4);
            Controls.Add(btnPreviousMonth);
            Controls.Add(btnNextMonth);
            Controls.Add(lblDate);
            Controls.Add(hScrollBar1);
            Controls.Add(vScrollBar1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            SizeChanged += Form1_SizeChanged;
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private Panel panel4;
        private Label lblDate;
        private Button btnNextMonth;
        private Button btnPreviousMonth;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}
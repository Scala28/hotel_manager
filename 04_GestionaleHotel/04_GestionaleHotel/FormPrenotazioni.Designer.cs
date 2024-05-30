namespace _04_GestionaleHotel
{
    partial class FormPrenotazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrenotazioni));
            dgwPrenotazioni = new DataGridView();
            btnModifica = new Button();
            btnAggiungi = new Button();
            btnElimina = new Button();
            sideBar = new Panel();
            gbFilters = new GroupBox();
            label4 = new Label();
            cboTrattamento = new ComboBox();
            btnResetFilters = new Button();
            button1 = new Button();
            dtpFilter = new DateTimePicker();
            btnFiltra = new Button();
            label3 = new Label();
            cboCamere = new ComboBox();
            label2 = new Label();
            cboClienti = new ComboBox();
            label1 = new Label();
            btnFilters = new Button();
            imageList1 = new ImageList(components);
            sideBarTimer = new System.Windows.Forms.Timer(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwPrenotazioni).BeginInit();
            sideBar.SuspendLayout();
            gbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // dgwPrenotazioni
            // 
            dgwPrenotazioni.AllowUserToAddRows = false;
            dgwPrenotazioni.AllowUserToDeleteRows = false;
            dgwPrenotazioni.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgwPrenotazioni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwPrenotazioni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwPrenotazioni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwPrenotazioni.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwPrenotazioni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgwPrenotazioni.ColumnHeadersHeight = 60;
            dgwPrenotazioni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgwPrenotazioni.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwPrenotazioni.DefaultCellStyle = dataGridViewCellStyle3;
            dgwPrenotazioni.EnableHeadersVisualStyles = false;
            dgwPrenotazioni.Location = new Point(22, 26);
            dgwPrenotazioni.Margin = new Padding(6);
            dgwPrenotazioni.MultiSelect = false;
            dgwPrenotazioni.Name = "dgwPrenotazioni";
            dgwPrenotazioni.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgwPrenotazioni.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgwPrenotazioni.RowHeadersVisible = false;
            dgwPrenotazioni.RowHeadersWidth = 82;
            dgwPrenotazioni.RowTemplate.Height = 40;
            dgwPrenotazioni.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwPrenotazioni.Size = new Size(1313, 868);
            dgwPrenotazioni.TabIndex = 0;
            dgwPrenotazioni.SelectionChanged += dgwPrenotazioni_SelectionChanged;
            // 
            // btnModifica
            // 
            btnModifica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModifica.BackColor = Color.FromArgb(0, 64, 64);
            btnModifica.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifica.ForeColor = Color.White;
            btnModifica.Location = new Point(22, 907);
            btnModifica.Margin = new Padding(6);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(204, 100);
            btnModifica.TabIndex = 1;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = false;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAggiungi.BackColor = Color.FromArgb(0, 64, 64);
            btnAggiungi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungi.ForeColor = Color.White;
            btnAggiungi.Location = new Point(238, 907);
            btnAggiungi.Margin = new Padding(6);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(204, 100);
            btnAggiungi.TabIndex = 2;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = false;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnElimina
            // 
            btnElimina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnElimina.BackColor = Color.FromArgb(0, 64, 64);
            btnElimina.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnElimina.ForeColor = Color.White;
            btnElimina.Location = new Point(453, 907);
            btnElimina.Margin = new Padding(6);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(204, 100);
            btnElimina.TabIndex = 3;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = false;
            btnElimina.Click += btnElimina_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(0, 64, 64);
            sideBar.Controls.Add(gbFilters);
            sideBar.Controls.Add(btnFilters);
            sideBar.Dock = DockStyle.Right;
            sideBar.Location = new Point(1348, 0);
            sideBar.Margin = new Padding(6);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(409, 1058);
            sideBar.TabIndex = 4;
            // 
            // gbFilters
            // 
            gbFilters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gbFilters.Controls.Add(label4);
            gbFilters.Controls.Add(cboTrattamento);
            gbFilters.Controls.Add(btnResetFilters);
            gbFilters.Controls.Add(button1);
            gbFilters.Controls.Add(dtpFilter);
            gbFilters.Controls.Add(btnFiltra);
            gbFilters.Controls.Add(label3);
            gbFilters.Controls.Add(cboCamere);
            gbFilters.Controls.Add(label2);
            gbFilters.Controls.Add(cboClienti);
            gbFilters.Controls.Add(label1);
            gbFilters.Location = new Point(6, 173);
            gbFilters.Margin = new Padding(6);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(6);
            gbFilters.Size = new Size(403, 834);
            gbFilters.TabIndex = 1;
            gbFilters.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 279);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 36);
            label4.TabIndex = 11;
            label4.Text = "Trattamento:";
            // 
            // cboTrattamento
            // 
            cboTrattamento.FormattingEnabled = true;
            cboTrattamento.Location = new Point(11, 322);
            cboTrattamento.Margin = new Padding(6);
            cboTrattamento.Name = "cboTrattamento";
            cboTrattamento.Size = new Size(297, 40);
            cboTrattamento.TabIndex = 10;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetFilters.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetFilters.Location = new Point(95, 734);
            btnResetFilters.Margin = new Padding(6);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(217, 81);
            btnResetFilters.TabIndex = 9;
            btnResetFilters.Text = "Reset filters";
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // button1
            // 
            button1.Location = new Point(351, 452);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(43, 49);
            button1.TabIndex = 8;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpFilter
            // 
            dtpFilter.CustomFormat = "";
            dtpFilter.Format = DateTimePickerFormat.Short;
            dtpFilter.Location = new Point(11, 452);
            dtpFilter.Margin = new Padding(6);
            dtpFilter.Name = "dtpFilter";
            dtpFilter.Size = new Size(325, 39);
            dtpFilter.TabIndex = 7;
            dtpFilter.ValueChanged += dtpFilter_ValueChanged;
            // 
            // btnFiltra
            // 
            btnFiltra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltra.Location = new Point(59, 570);
            btnFiltra.Margin = new Padding(6);
            btnFiltra.Name = "btnFiltra";
            btnFiltra.Size = new Size(280, 115);
            btnFiltra.TabIndex = 6;
            btnFiltra.Text = "Filtra prenotazioni";
            btnFiltra.UseVisualStyleBackColor = true;
            btnFiltra.Click += btnFiltra_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 410);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 36);
            label3.TabIndex = 5;
            label3.Text = "Mese:";
            // 
            // cboCamere
            // 
            cboCamere.FormattingEnabled = true;
            cboCamere.Location = new Point(126, 179);
            cboCamere.Margin = new Padding(6);
            cboCamere.Name = "cboCamere";
            cboCamere.Size = new Size(251, 40);
            cboCamere.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 181);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 36);
            label2.TabIndex = 2;
            label2.Text = "Camera:";
            // 
            // cboClienti
            // 
            cboClienti.FormattingEnabled = true;
            cboClienti.Location = new Point(126, 81);
            cboClienti.Margin = new Padding(6);
            cboClienti.Name = "cboClienti";
            cboClienti.Size = new Size(251, 40);
            cboClienti.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 83);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 36);
            label1.TabIndex = 0;
            label1.Text = "Cliente: ";
            // 
            // btnFilters
            // 
            btnFilters.FlatAppearance.BorderSize = 0;
            btnFilters.FlatStyle = FlatStyle.Flat;
            btnFilters.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilters.ForeColor = Color.White;
            btnFilters.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilters.ImageIndex = 0;
            btnFilters.ImageList = imageList1;
            btnFilters.Location = new Point(0, 58);
            btnFilters.Margin = new Padding(6);
            btnFilters.Name = "btnFilters";
            btnFilters.Padding = new Padding(22, 0, 0, 0);
            btnFilters.Size = new Size(409, 102);
            btnFilters.TabIndex = 0;
            btnFilters.Text = "    Filters";
            btnFilters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFilters.UseVisualStyleBackColor = true;
            btnFilters.Click += btnFilters_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "filtersWhite.png");
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "CheckIn";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "CheckOut";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Persone";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Trattamento";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "IDCliente";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "IDCamera";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Costo";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // FormPrenotazioni
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1757, 1058);
            Controls.Add(sideBar);
            Controls.Add(btnElimina);
            Controls.Add(btnAggiungi);
            Controls.Add(btnModifica);
            Controls.Add(dgwPrenotazioni);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormPrenotazioni";
            Text = "FormPrenotazioni";
            ((System.ComponentModel.ISupportInitialize)dgwPrenotazioni).EndInit();
            sideBar.ResumeLayout(false);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwPrenotazioni;
        private Button btnModifica;
        private Button btnAggiungi;
        private Button btnElimina;
        private Panel sideBar;
        private ImageList imageList1;
        private Button btnFilters;
        private System.Windows.Forms.Timer sideBarTimer;
        private GroupBox gbFilters;
        private Label label1;
        private Button btnFiltra;
        private Label label3;
        private ComboBox cboCamere;
        private Label label2;
        private ComboBox cboClienti;
        private DateTimePicker dtpFilter;
        private Button button1;
        private Button btnResetFilters;
        private Label label4;
        private ComboBox cboTrattamento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
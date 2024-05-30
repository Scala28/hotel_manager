namespace _04_GestionaleHotel
{
    partial class FormClienti
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabellaClienti = new DataGridView();
            btnElimina = new Button();
            btnAggiungi = new Button();
            btnModifica = new Button();
            ((System.ComponentModel.ISupportInitialize)tabellaClienti).BeginInit();
            SuspendLayout();
            // 
            // tabellaClienti
            // 
            tabellaClienti.AllowUserToAddRows = false;
            tabellaClienti.AllowUserToDeleteRows = false;
            tabellaClienti.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            tabellaClienti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tabellaClienti.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabellaClienti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaClienti.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tabellaClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tabellaClienti.ColumnHeadersHeight = 60;
            tabellaClienti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tabellaClienti.DefaultCellStyle = dataGridViewCellStyle3;
            tabellaClienti.EnableHeadersVisualStyles = false;
            tabellaClienti.Location = new Point(22, 26);
            tabellaClienti.Margin = new Padding(6, 6, 6, 6);
            tabellaClienti.MultiSelect = false;
            tabellaClienti.Name = "tabellaClienti";
            tabellaClienti.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Aquamarine;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tabellaClienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tabellaClienti.RowHeadersVisible = false;
            tabellaClienti.RowHeadersWidth = 82;
            tabellaClienti.RowTemplate.Height = 40;
            tabellaClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabellaClienti.Size = new Size(1712, 868);
            tabellaClienti.TabIndex = 0;
            tabellaClienti.SelectionChanged += tabellaClienti_SelectionChanged;
            // 
            // btnElimina
            // 
            btnElimina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnElimina.BackColor = Color.FromArgb(0, 64, 64);
            btnElimina.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnElimina.ForeColor = Color.White;
            btnElimina.Location = new Point(453, 907);
            btnElimina.Margin = new Padding(6, 6, 6, 6);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(204, 100);
            btnElimina.TabIndex = 6;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = false;
            btnElimina.Click += btnElimina_Click;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAggiungi.BackColor = Color.FromArgb(0, 64, 64);
            btnAggiungi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungi.ForeColor = Color.White;
            btnAggiungi.Location = new Point(238, 907);
            btnAggiungi.Margin = new Padding(6, 6, 6, 6);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(204, 100);
            btnAggiungi.TabIndex = 5;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = false;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnModifica
            // 
            btnModifica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModifica.BackColor = Color.FromArgb(0, 64, 64);
            btnModifica.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifica.ForeColor = Color.White;
            btnModifica.Location = new Point(22, 907);
            btnModifica.Margin = new Padding(6, 6, 6, 6);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(204, 100);
            btnModifica.TabIndex = 4;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = false;
            btnModifica.Click += btnModifica_Click;
            // 
            // FormClienti
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1757, 1058);
            Controls.Add(btnElimina);
            Controls.Add(btnAggiungi);
            Controls.Add(btnModifica);
            Controls.Add(tabellaClienti);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormClienti";
            Text = "FormClienti";
            ((System.ComponentModel.ISupportInitialize)tabellaClienti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabellaClienti;
        private Button btnElimina;
        private Button btnAggiungi;
        private Button btnModifica;
    }
}
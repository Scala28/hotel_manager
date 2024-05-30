namespace _04_GestionaleHotel
{
    partial class OggettoCamera
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblID = new Label();
            groupBox1 = new GroupBox();
            lblCosto = new Label();
            lblRecensione = new Label();
            lblPosti = new Label();
            btnModifica = new Button();
            btnElimina = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 247);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(11, 68);
            lblID.Margin = new Padding(6, 0, 6, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(83, 36);
            lblID.TabIndex = 1;
            lblID.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblCosto);
            groupBox1.Controls.Add(lblRecensione);
            groupBox1.Controls.Add(lblPosti);
            groupBox1.Controls.Add(lblID);
            groupBox1.Location = new Point(394, 0);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(730, 260);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCosto.Location = new Point(331, 68);
            lblCosto.Margin = new Padding(6, 0, 6, 0);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(83, 36);
            lblCosto.TabIndex = 4;
            lblCosto.Text = "label1";
            // 
            // lblRecensione
            // 
            lblRecensione.AutoSize = true;
            lblRecensione.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecensione.Location = new Point(11, 181);
            lblRecensione.Margin = new Padding(6, 0, 6, 0);
            lblRecensione.Name = "lblRecensione";
            lblRecensione.Size = new Size(83, 36);
            lblRecensione.TabIndex = 3;
            lblRecensione.Text = "label1";
            // 
            // lblPosti
            // 
            lblPosti.AutoSize = true;
            lblPosti.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPosti.Location = new Point(11, 124);
            lblPosti.Margin = new Padding(6, 0, 6, 0);
            lblPosti.Name = "lblPosti";
            lblPosti.Size = new Size(83, 36);
            lblPosti.TabIndex = 2;
            lblPosti.Text = "label1";
            // 
            // btnModifica
            // 
            btnModifica.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModifica.BackColor = Color.FromArgb(128, 255, 255);
            btnModifica.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifica.Location = new Point(1185, 24);
            btnModifica.Margin = new Padding(6);
            btnModifica.Name = "btnModifica";
            btnModifica.Size = new Size(160, 80);
            btnModifica.TabIndex = 3;
            btnModifica.Text = "Modifica";
            btnModifica.UseVisualStyleBackColor = false;
            btnModifica.Click += btnModifica_Click;
            // 
            // btnElimina
            // 
            btnElimina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnElimina.BackColor = Color.FromArgb(255, 128, 128);
            btnElimina.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnElimina.Location = new Point(1185, 159);
            btnElimina.Margin = new Padding(6);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(160, 80);
            btnElimina.TabIndex = 4;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = false;
            btnElimina.Click += btnElimina_Click;
            // 
            // OggettoCamera
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnElimina);
            Controls.Add(btnModifica);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Margin = new Padding(6);
            Name = "OggettoCamera";
            Size = new Size(1378, 260);
            Load += OggettoCamera_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblID;
        private GroupBox groupBox1;
        private Label lblRecensione;
        private Label lblPosti;
        private Label lblCosto;
        private Button btnModifica;
        private Button btnElimina;
    }
}

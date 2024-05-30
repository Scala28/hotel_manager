namespace _04_GestionaleHotel
{
    partial class VisualizzazionePrenotazione
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCamere = new System.Windows.Forms.ComboBox();
            this.lblGiorni = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblTrattamento = new System.Windows.Forms.Label();
            this.btnCamera = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboTrattamento = new System.Windows.Forms.ComboBox();
            this.txtNumPersone = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnApplica = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblPrenotazione = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddCliente);
            this.groupBox1.Controls.Add(this.cboCamere);
            this.groupBox1.Controls.Add(this.lblGiorni);
            this.groupBox1.Controls.Add(this.lblCamera);
            this.groupBox1.Controls.Add(this.lblTrattamento);
            this.groupBox1.Controls.Add(this.btnCamera);
            this.groupBox1.Controls.Add(this.lblCosto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpCheckOut);
            this.groupBox1.Controls.Add(this.dtpCheckIn);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.cboTrattamento);
            this.groupBox1.Controls.Add(this.txtNumPersone);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dettagli prenotazione";
            // 
            // cboCamere
            // 
            this.cboCamere.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCamere.FormattingEnabled = true;
            this.cboCamere.Location = new System.Drawing.Point(120, 246);
            this.cboCamere.Name = "cboCamere";
            this.cboCamere.Size = new System.Drawing.Size(161, 25);
            this.cboCamere.TabIndex = 20;
            this.cboCamere.SelectedIndexChanged += new System.EventHandler(this.cboCamere_SelectedIndexChanged);
            this.cboCamere.TextChanged += new System.EventHandler(this.cboCamere_TextChanged);
            // 
            // lblGiorni
            // 
            this.lblGiorni.AutoSize = true;
            this.lblGiorni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGiorni.Location = new System.Drawing.Point(318, 101);
            this.lblGiorni.Name = "lblGiorni";
            this.lblGiorni.Size = new System.Drawing.Size(57, 17);
            this.lblGiorni.TabIndex = 19;
            this.lblGiorni.Text = "lblGiorni";
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamera.Location = new System.Drawing.Point(231, 293);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(67, 17);
            this.lblCamera.TabIndex = 18;
            this.lblCamera.Text = "lblCamera";
            // 
            // lblTrattamento
            // 
            this.lblTrattamento.AutoSize = true;
            this.lblTrattamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrattamento.Location = new System.Drawing.Point(287, 145);
            this.lblTrattamento.Name = "lblTrattamento";
            this.lblTrattamento.Size = new System.Drawing.Size(92, 17);
            this.lblTrattamento.TabIndex = 17;
            this.lblTrattamento.Text = "lblTrattamento";
            // 
            // btnCamera
            // 
            this.btnCamera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCamera.Location = new System.Drawing.Point(120, 281);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(92, 40);
            this.btnCamera.TabIndex = 16;
            this.btnCamera.Text = "btnCamera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(407, 220);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(51, 15);
            this.lblCosto.TabIndex = 15;
            this.lblCosto.Text = "lblCosto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(408, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Totale:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(318, 75);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 23);
            this.dtpCheckOut.TabIndex = 13;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(318, 33);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 23);
            this.dtpCheckIn.TabIndex = 12;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(120, 193);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(161, 25);
            this.cboCliente.TabIndex = 10;
            // 
            // cboTrattamento
            // 
            this.cboTrattamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTrattamento.FormattingEnabled = true;
            this.cboTrattamento.Location = new System.Drawing.Point(120, 142);
            this.cboTrattamento.Name = "cboTrattamento";
            this.cboTrattamento.Size = new System.Drawing.Size(161, 25);
            this.cboTrattamento.TabIndex = 9;
            this.cboTrattamento.SelectedIndexChanged += new System.EventHandler(this.cboTrattamento_SelectedIndexChanged);
            this.cboTrattamento.TextChanged += new System.EventHandler(this.cboTrattamento_TextChanged);
            // 
            // txtNumPersone
            // 
            this.txtNumPersone.Location = new System.Drawing.Point(120, 78);
            this.txtNumPersone.Name = "txtNumPersone";
            this.txtNumPersone.Size = new System.Drawing.Size(100, 23);
            this.txtNumPersone.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(120, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 17);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "lblID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID camera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trattamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero persone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(231, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Check Out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(231, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check In:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID prenotazione:";
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnnulla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnnulla.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnulla.Location = new System.Drawing.Point(143, 394);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(119, 43);
            this.btnAnnulla.TabIndex = 11;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnApplica
            // 
            this.btnApplica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnApplica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApplica.Location = new System.Drawing.Point(18, 394);
            this.btnApplica.Name = "btnApplica";
            this.btnApplica.Size = new System.Drawing.Size(119, 43);
            this.btnApplica.TabIndex = 10;
            this.btnApplica.Text = "Conferma";
            this.btnApplica.UseVisualStyleBackColor = false;
            this.btnApplica.Click += new System.EventHandler(this.btnApplica_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDay.Location = new System.Drawing.Point(18, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(55, 21);
            this.lblDay.TabIndex = 12;
            this.lblDay.Text = "lblDay";
            // 
            // lblPrenotazione
            // 
            this.lblPrenotazione.AutoSize = true;
            this.lblPrenotazione.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrenotazione.Location = new System.Drawing.Point(115, 13);
            this.lblPrenotazione.Name = "lblPrenotazione";
            this.lblPrenotazione.Size = new System.Drawing.Size(102, 17);
            this.lblPrenotazione.TabIndex = 13;
            this.lblPrenotazione.Text = "lblPrenotazione";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCliente.Location = new System.Drawing.Point(287, 189);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(30, 30);
            this.btnAddCliente.TabIndex = 21;
            this.btnAddCliente.Text = "+";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // VisualizzazionePrenotazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 449);
            this.Controls.Add(this.lblPrenotazione);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnApplica);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisualizzazionePrenotazione";
            this.Text = "VisualizzazionePrenotazione";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNumPersone;
        private Label lblID;
        private ComboBox cboCliente;
        private ComboBox cboTrattamento;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Label lblCosto;
        private Label label8;
        private Button btnAnnulla;
        private Button btnApplica;
        private Label lblDay;
        private Label lblPrenotazione;
        private Button btnCamera;
        private Label lblTrattamento;
        private Label lblCamera;
        private Label lblGiorni;
        private ComboBox cboCamere;
        private Button btnAddCliente;
    }
}
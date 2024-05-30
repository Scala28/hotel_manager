namespace _04_GestionaleHotel
{
    partial class BlankUserControl
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
            this.btnPrenotazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrenotazione
            // 
            this.btnPrenotazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrenotazione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrenotazione.Location = new System.Drawing.Point(0, 0);
            this.btnPrenotazione.Name = "btnPrenotazione";
            this.btnPrenotazione.Size = new System.Drawing.Size(164, 101);
            this.btnPrenotazione.TabIndex = 0;
            this.btnPrenotazione.UseVisualStyleBackColor = false;
            this.btnPrenotazione.Click += new System.EventHandler(this.btnPrenotazione_Click);
            // 
            // BlankUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrenotazione);
            this.Name = "BlankUserControl";
            this.Size = new System.Drawing.Size(164, 101);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPrenotazione;
    }
}

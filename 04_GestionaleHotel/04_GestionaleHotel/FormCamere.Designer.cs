namespace _04_GestionaleHotel
{
    partial class FormCamere
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
            this.roomContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomContainer
            // 
            this.roomContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roomContainer.Location = new System.Drawing.Point(12, 12);
            this.roomContainer.Name = "roomContainer";
            this.roomContainer.Size = new System.Drawing.Size(776, 351);
            this.roomContainer.TabIndex = 0;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAggiungi.BackColor = System.Drawing.Color.White;
            this.btnAggiungi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAggiungi.Location = new System.Drawing.Point(12, 369);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(148, 50);
            this.btnAggiungi.TabIndex = 1;
            this.btnAggiungi.Text = "Nuova camera";
            this.btnAggiungi.UseVisualStyleBackColor = false;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // FormCamere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.roomContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCamere";
            this.Text = "FormCamere";
            this.Shown += new System.EventHandler(this.FormCamere_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel roomContainer;
        private Button btnAggiungi;
    }
}
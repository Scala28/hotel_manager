namespace _04_GestionaleHotel
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnClienti = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrenotazioni = new System.Windows.Forms.Button();
            this.btnCamere = new System.Windows.Forms.Button();
            this.btnTabella = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnTrattamenti = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.btnTrattamenti);
            this.panelSideMenu.Controls.Add(this.btnClienti);
            this.panelSideMenu.Controls.Add(this.btnPrenotazioni);
            this.panelSideMenu.Controls.Add(this.btnCamere);
            this.panelSideMenu.Controls.Add(this.btnTabella);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 508);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnClienti
            // 
            this.btnClienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienti.FlatAppearance.BorderSize = 0;
            this.btnClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienti.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClienti.ForeColor = System.Drawing.Color.White;
            this.btnClienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienti.ImageIndex = 3;
            this.btnClienti.ImageList = this.imageList1;
            this.btnClienti.Location = new System.Drawing.Point(0, 135);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClienti.Size = new System.Drawing.Size(200, 45);
            this.btnClienti.TabIndex = 3;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cameraWhite.png");
            this.imageList1.Images.SetKeyName(1, "whiteTable.png");
            this.imageList1.Images.SetKeyName(2, "prenotazionewhite.png");
            this.imageList1.Images.SetKeyName(3, "usersWhite.png");
            this.imageList1.Images.SetKeyName(4, "moneyWhite.png");
            // 
            // btnPrenotazioni
            // 
            this.btnPrenotazioni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrenotazioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrenotazioni.FlatAppearance.BorderSize = 0;
            this.btnPrenotazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrenotazioni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrenotazioni.ForeColor = System.Drawing.Color.White;
            this.btnPrenotazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrenotazioni.ImageIndex = 2;
            this.btnPrenotazioni.ImageList = this.imageList1;
            this.btnPrenotazioni.Location = new System.Drawing.Point(0, 90);
            this.btnPrenotazioni.Name = "btnPrenotazioni";
            this.btnPrenotazioni.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPrenotazioni.Size = new System.Drawing.Size(200, 45);
            this.btnPrenotazioni.TabIndex = 2;
            this.btnPrenotazioni.Text = "Prenotazioni";
            this.btnPrenotazioni.UseVisualStyleBackColor = true;
            this.btnPrenotazioni.Click += new System.EventHandler(this.btnPrenotazioni_Click);
            // 
            // btnCamere
            // 
            this.btnCamere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCamere.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCamere.FlatAppearance.BorderSize = 0;
            this.btnCamere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamere.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCamere.ForeColor = System.Drawing.Color.White;
            this.btnCamere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamere.ImageIndex = 0;
            this.btnCamere.ImageList = this.imageList1;
            this.btnCamere.Location = new System.Drawing.Point(0, 45);
            this.btnCamere.Name = "btnCamere";
            this.btnCamere.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCamere.Size = new System.Drawing.Size(200, 45);
            this.btnCamere.TabIndex = 1;
            this.btnCamere.Text = "Camere";
            this.btnCamere.UseVisualStyleBackColor = true;
            this.btnCamere.Click += new System.EventHandler(this.btnCamere_Click);
            // 
            // btnTabella
            // 
            this.btnTabella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTabella.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabella.FlatAppearance.BorderSize = 0;
            this.btnTabella.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabella.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabella.ForeColor = System.Drawing.Color.White;
            this.btnTabella.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabella.ImageIndex = 1;
            this.btnTabella.ImageList = this.imageList1;
            this.btnTabella.Location = new System.Drawing.Point(0, 0);
            this.btnTabella.Name = "btnTabella";
            this.btnTabella.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabella.Size = new System.Drawing.Size(200, 45);
            this.btnTabella.TabIndex = 0;
            this.btnTabella.Text = "Tabella prenotazioni";
            this.btnTabella.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTabella.UseVisualStyleBackColor = true;
            this.btnTabella.Click += new System.EventHandler(this.btnTabella_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(748, 508);
            this.panelChildForm.TabIndex = 1;
            // 
            // btnTrattamenti
            // 
            this.btnTrattamenti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrattamenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrattamenti.FlatAppearance.BorderSize = 0;
            this.btnTrattamenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrattamenti.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrattamenti.ForeColor = System.Drawing.Color.White;
            this.btnTrattamenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrattamenti.ImageIndex = 4;
            this.btnTrattamenti.ImageList = this.imageList1;
            this.btnTrattamenti.Location = new System.Drawing.Point(0, 180);
            this.btnTrattamenti.Name = "btnTrattamenti";
            this.btnTrattamenti.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrattamenti.Size = new System.Drawing.Size(200, 45);
            this.btnTrattamenti.TabIndex = 4;
            this.btnTrattamenti.Text = "Trattamenti";
            this.btnTrattamenti.UseVisualStyleBackColor = true;
            this.btnTrattamenti.Click += new System.EventHandler(this.btnTrattamenti_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResizeEnd += new System.EventHandler(this.HomeForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.HomeForm_SizeChanged);
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Button btnTabella;
        private Panel panelChildForm;
        private Button btnCamere;
        private ImageList imageList1;
        private Button btnPrenotazioni;
        private Button btnClienti;
        private Button btnTrattamenti;
    }
}
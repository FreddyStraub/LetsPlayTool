namespace LetsPlayTool
{
    partial class frmÜFenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmÜFenster));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbRAMUsed = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.lbCPUAuslastung = new System.Windows.Forms.Label();
            this.lbCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.HeaderBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(274, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(321, 59);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(16, 97);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(152, 55);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "label1";
            // 
            // lbRAMUsed
            // 
            this.lbRAMUsed.AutoSize = true;
            this.lbRAMUsed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRAMUsed.ForeColor = System.Drawing.Color.White;
            this.lbRAMUsed.Location = new System.Drawing.Point(237, 177);
            this.lbRAMUsed.Name = "lbRAMUsed";
            this.lbRAMUsed.Size = new System.Drawing.Size(19, 21);
            this.lbRAMUsed.TabIndex = 13;
            this.lbRAMUsed.Text = "...";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRAM.ForeColor = System.Drawing.Color.White;
            this.lbRAM.Location = new System.Drawing.Point(149, 177);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(91, 21);
            this.lbRAM.TabIndex = 12;
            this.lbRAM.Text = "Freier RAM:";
            // 
            // lbCPUAuslastung
            // 
            this.lbCPUAuslastung.AutoSize = true;
            this.lbCPUAuslastung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPUAuslastung.ForeColor = System.Drawing.Color.White;
            this.lbCPUAuslastung.Location = new System.Drawing.Point(53, 177);
            this.lbCPUAuslastung.Name = "lbCPUAuslastung";
            this.lbCPUAuslastung.Size = new System.Drawing.Size(19, 21);
            this.lbCPUAuslastung.TabIndex = 11;
            this.lbCPUAuslastung.Text = "...";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPU.ForeColor = System.Drawing.Color.White;
            this.lbCPU.Location = new System.Drawing.Point(12, 177);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(43, 21);
            this.lbCPU.TabIndex = 10;
            this.lbCPU.Text = "CPU:";
            // 
            // frmÜFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(321, 207);
            this.Controls.Add(this.lbRAMUsed);
            this.Controls.Add(this.lbRAM);
            this.Controls.Add(this.lbCPUAuslastung);
            this.Controls.Add(this.lbCPU);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmÜFenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmÜFenster";
            this.Activated += new System.EventHandler(this.frmÜFenster_Activated);
            this.TextChanged += new System.EventHandler(this.frmÜFenster_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.HeaderBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel HeaderBar;
        private System.Windows.Forms.Label lbTimer;
        public System.Windows.Forms.Label lbRAMUsed;
        public System.Windows.Forms.Label lbRAM;
        public System.Windows.Forms.Label lbCPUAuslastung;
        public System.Windows.Forms.Label lbCPU;
    }
}
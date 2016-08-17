namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class Überwachung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Überwachung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAufnahmeordner = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.switchGPU = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.switchCPU = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.switchSpeicherplatz = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbDiscord = new System.Windows.Forms.PictureBox();
            this.pbTeamspeak = new System.Windows.Forms.PictureBox();
            this.pbSkype = new System.Windows.Forms.PictureBox();
            this.fbdAufnahmeordner = new Ookii.Dialogs.VistaFolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamspeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkype)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAufnahmeordner);
            this.groupBox1.Controls.Add(this.bBrowse);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordnerüberwachung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aufnahmeordner:";
            // 
            // tbAufnahmeordner
            // 
            this.tbAufnahmeordner.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbAufnahmeordner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAufnahmeordner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAufnahmeordner.ForeColor = System.Drawing.Color.White;
            this.tbAufnahmeordner.Location = new System.Drawing.Point(127, 34);
            this.tbAufnahmeordner.Multiline = true;
            this.tbAufnahmeordner.Name = "tbAufnahmeordner";
            this.tbAufnahmeordner.ReadOnly = true;
            this.tbAufnahmeordner.Size = new System.Drawing.Size(486, 25);
            this.tbAufnahmeordner.TabIndex = 3;
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.bBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.ForeColor = System.Drawing.Color.White;
            this.bBrowse.Location = new System.Drawing.Point(619, 34);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(30, 25);
            this.bBrowse.TabIndex = 4;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.switchGPU);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.switchCPU);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.switchSpeicherplatz);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anzeige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "GPU";
            // 
            // switchGPU
            // 
            this.switchGPU.BackColor = System.Drawing.Color.Transparent;
            this.switchGPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchGPU.BackgroundImage")));
            this.switchGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchGPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchGPU.Location = new System.Drawing.Point(357, 37);
            this.switchGPU.Name = "switchGPU";
            this.switchGPU.OffColor = System.Drawing.Color.Gray;
            this.switchGPU.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchGPU.Size = new System.Drawing.Size(43, 25);
            this.switchGPU.TabIndex = 11;
            this.switchGPU.Value = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU";
            // 
            // switchCPU
            // 
            this.switchCPU.BackColor = System.Drawing.Color.Transparent;
            this.switchCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCPU.BackgroundImage")));
            this.switchCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchCPU.Location = new System.Drawing.Point(229, 37);
            this.switchCPU.Name = "switchCPU";
            this.switchCPU.OffColor = System.Drawing.Color.Gray;
            this.switchCPU.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchCPU.Size = new System.Drawing.Size(43, 25);
            this.switchCPU.TabIndex = 9;
            this.switchCPU.Value = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speicherplatz";
            // 
            // switchSpeicherplatz
            // 
            this.switchSpeicherplatz.BackColor = System.Drawing.Color.Transparent;
            this.switchSpeicherplatz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchSpeicherplatz.BackgroundImage")));
            this.switchSpeicherplatz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchSpeicherplatz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchSpeicherplatz.Location = new System.Drawing.Point(106, 37);
            this.switchSpeicherplatz.Name = "switchSpeicherplatz";
            this.switchSpeicherplatz.OffColor = System.Drawing.Color.Gray;
            this.switchSpeicherplatz.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchSpeicherplatz.Size = new System.Drawing.Size(43, 25);
            this.switchSpeicherplatz.TabIndex = 7;
            this.switchSpeicherplatz.Value = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbDiscord);
            this.groupBox3.Controls.Add(this.pbTeamspeak);
            this.groupBox3.Controls.Add(this.pbSkype);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 345);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Messenger";
            // 
            // pbDiscord
            // 
            this.pbDiscord.Image = ((System.Drawing.Image)(resources.GetObject("pbDiscord.Image")));
            this.pbDiscord.Location = new System.Drawing.Point(10, 241);
            this.pbDiscord.Name = "pbDiscord";
            this.pbDiscord.Size = new System.Drawing.Size(70, 70);
            this.pbDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDiscord.TabIndex = 2;
            this.pbDiscord.TabStop = false;
            // 
            // pbTeamspeak
            // 
            this.pbTeamspeak.Image = ((System.Drawing.Image)(resources.GetObject("pbTeamspeak.Image")));
            this.pbTeamspeak.Location = new System.Drawing.Point(10, 140);
            this.pbTeamspeak.Name = "pbTeamspeak";
            this.pbTeamspeak.Size = new System.Drawing.Size(70, 70);
            this.pbTeamspeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeamspeak.TabIndex = 1;
            this.pbTeamspeak.TabStop = false;
            // 
            // pbSkype
            // 
            this.pbSkype.Image = ((System.Drawing.Image)(resources.GetObject("pbSkype.Image")));
            this.pbSkype.Location = new System.Drawing.Point(10, 42);
            this.pbSkype.Name = "pbSkype";
            this.pbSkype.Size = new System.Drawing.Size(70, 70);
            this.pbSkype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSkype.TabIndex = 0;
            this.pbSkype.TabStop = false;
            // 
            // Überwachung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Überwachung";
            this.Text = "OrdnerüberwachungTab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamspeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAufnahmeordner;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchSpeicherplatz;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchGPU;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCPU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbDiscord;
        private System.Windows.Forms.PictureBox pbTeamspeak;
        private System.Windows.Forms.PictureBox pbSkype;
        private Ookii.Dialogs.VistaFolderBrowserDialog fbdAufnahmeordner;
    }
}
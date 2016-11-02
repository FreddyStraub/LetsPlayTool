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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Überwachung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAufnahmeordner = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFRam = new System.Windows.Forms.Label();
            this.switchRAM = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.switchCPU = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bTeamspeak = new Bunifu.Framework.UI.BunifuImageButton();
            this.bDiscord = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMessengerSwitch = new System.Windows.Forms.Panel();
            this.bSkype = new Bunifu.Framework.UI.BunifuImageButton();
            this.fbdAufnahmeordner = new Ookii.Dialogs.VistaFolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bTeamspeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSkype)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAufnahmeordner);
            this.groupBox1.Controls.Add(this.bBrowse);
            this.panelAnimator.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aufnahmeordner:";
            // 
            // tbAufnahmeordner
            // 
            this.tbAufnahmeordner.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbAufnahmeordner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelAnimator.SetDecoration(this.tbAufnahmeordner, BunifuAnimatorNS.DecorationType.None);
            this.tbAufnahmeordner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAufnahmeordner.ForeColor = System.Drawing.Color.White;
            this.tbAufnahmeordner.Location = new System.Drawing.Point(127, 34);
            this.tbAufnahmeordner.Multiline = true;
            this.tbAufnahmeordner.Name = "tbAufnahmeordner";
            this.tbAufnahmeordner.ReadOnly = true;
            this.tbAufnahmeordner.Size = new System.Drawing.Size(486, 25);
            this.tbAufnahmeordner.TabIndex = 3;
            this.tbAufnahmeordner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbAufnahmeordner_MouseDown);
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.bBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bBrowse, BunifuAnimatorNS.DecorationType.None);
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.ForeColor = System.Drawing.Color.White;
            this.bBrowse.Location = new System.Drawing.Point(619, 34);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(30, 25);
            this.bBrowse.TabIndex = 4;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            this.bBrowse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bBrowse_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbFRam);
            this.groupBox2.Controls.Add(this.switchRAM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.switchCPU);
            this.panelAnimator.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anzeige";
            // 
            // lbFRam
            // 
            this.lbFRam.AutoSize = true;
            this.panelAnimator.SetDecoration(this.lbFRam, BunifuAnimatorNS.DecorationType.None);
            this.lbFRam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFRam.Location = new System.Drawing.Point(122, 40);
            this.lbFRam.Name = "lbFRam";
            this.lbFRam.Size = new System.Drawing.Size(73, 17);
            this.lbFRam.TabIndex = 12;
            this.lbFRam.Text = "Freier RAM";
            // 
            // switchRAM
            // 
            this.switchRAM.BackColor = System.Drawing.Color.Transparent;
            this.switchRAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchRAM.BackgroundImage")));
            this.switchRAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.switchRAM, BunifuAnimatorNS.DecorationType.None);
            this.switchRAM.Location = new System.Drawing.Point(204, 37);
            this.switchRAM.Name = "switchRAM";
            this.switchRAM.OffColor = System.Drawing.Color.Gray;
            this.switchRAM.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchRAM.Size = new System.Drawing.Size(43, 25);
            this.switchRAM.TabIndex = 11;
            this.switchRAM.Value = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.panelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU";
            // 
            // switchCPU
            // 
            this.switchCPU.BackColor = System.Drawing.Color.Transparent;
            this.switchCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCPU.BackgroundImage")));
            this.switchCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.switchCPU, BunifuAnimatorNS.DecorationType.None);
            this.switchCPU.Location = new System.Drawing.Point(57, 37);
            this.switchCPU.Name = "switchCPU";
            this.switchCPU.OffColor = System.Drawing.Color.Gray;
            this.switchCPU.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchCPU.Size = new System.Drawing.Size(43, 25);
            this.switchCPU.TabIndex = 9;
            this.switchCPU.Value = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bTeamspeak);
            this.groupBox3.Controls.Add(this.bDiscord);
            this.groupBox3.Controls.Add(this.panelMessengerSwitch);
            this.groupBox3.Controls.Add(this.bSkype);
            this.panelAnimator.SetDecoration(this.groupBox3, BunifuAnimatorNS.DecorationType.None);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 345);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Messenger";
            // 
            // bTeamspeak
            // 
            this.bTeamspeak.BackColor = System.Drawing.Color.Crimson;
            this.panelAnimator.SetDecoration(this.bTeamspeak, BunifuAnimatorNS.DecorationType.None);
            this.bTeamspeak.Image = ((System.Drawing.Image)(resources.GetObject("bTeamspeak.Image")));
            this.bTeamspeak.ImageActive = null;
            this.bTeamspeak.Location = new System.Drawing.Point(142, 21);
            this.bTeamspeak.Name = "bTeamspeak";
            this.bTeamspeak.Size = new System.Drawing.Size(60, 60);
            this.bTeamspeak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bTeamspeak.TabIndex = 3;
            this.bTeamspeak.TabStop = false;
            this.toolTip1.SetToolTip(this.bTeamspeak, "Nicht verfügbar");
            this.bTeamspeak.Zoom = 5;
            // 
            // bDiscord
            // 
            this.bDiscord.BackColor = System.Drawing.Color.Crimson;
            this.panelAnimator.SetDecoration(this.bDiscord, BunifuAnimatorNS.DecorationType.None);
            this.bDiscord.Image = ((System.Drawing.Image)(resources.GetObject("bDiscord.Image")));
            this.bDiscord.ImageActive = null;
            this.bDiscord.Location = new System.Drawing.Point(74, 21);
            this.bDiscord.Name = "bDiscord";
            this.bDiscord.Size = new System.Drawing.Size(60, 60);
            this.bDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bDiscord.TabIndex = 2;
            this.bDiscord.TabStop = false;
            this.toolTip1.SetToolTip(this.bDiscord, "Nicht verfügbar");
            this.bDiscord.Zoom = 5;
            // 
            // panelMessengerSwitch
            // 
            this.panelAnimator.SetDecoration(this.panelMessengerSwitch, BunifuAnimatorNS.DecorationType.None);
            this.panelMessengerSwitch.Location = new System.Drawing.Point(6, 87);
            this.panelMessengerSwitch.Name = "panelMessengerSwitch";
            this.panelMessengerSwitch.Size = new System.Drawing.Size(658, 252);
            this.panelMessengerSwitch.TabIndex = 1;
            this.panelMessengerSwitch.Visible = false;
            this.panelMessengerSwitch.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelMessengerSwitch_ControlAdded);
            // 
            // bSkype
            // 
            this.bSkype.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAnimator.SetDecoration(this.bSkype, BunifuAnimatorNS.DecorationType.None);
            this.bSkype.Image = ((System.Drawing.Image)(resources.GetObject("bSkype.Image")));
            this.bSkype.ImageActive = null;
            this.bSkype.Location = new System.Drawing.Point(6, 21);
            this.bSkype.Name = "bSkype";
            this.bSkype.Size = new System.Drawing.Size(60, 60);
            this.bSkype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bSkype.TabIndex = 0;
            this.bSkype.TabStop = false;
            this.bSkype.Zoom = 5;
            this.bSkype.Click += new System.EventHandler(this.bSkype_Click);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.panelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation1;
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
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Überwachung";
            this.Text = "OrdnerüberwachungTab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bTeamspeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSkype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAufnahmeordner;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbFRam;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchRAM;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCPU;
        private System.Windows.Forms.GroupBox groupBox3;
        private Ookii.Dialogs.VistaFolderBrowserDialog fbdAufnahmeordner;
        private Bunifu.Framework.UI.BunifuImageButton bSkype;
        private System.Windows.Forms.Panel panelMessengerSwitch;
        private Bunifu.Framework.UI.BunifuImageButton bTeamspeak;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton bDiscord;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
    }
}
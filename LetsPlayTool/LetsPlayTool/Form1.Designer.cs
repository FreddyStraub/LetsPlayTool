﻿namespace LetsPlayTool
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimaizeAnimation = new System.Windows.Forms.Timer(this.components);
            this.MaximaizeAnimation = new System.Windows.Forms.Timer(this.components);
            this.panelTimer = new System.Windows.Forms.Panel();
            this.bPause = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelOrdner = new System.Windows.Forms.Panel();
            this.lbCPUAuslastung = new System.Windows.Forms.Label();
            this.lbCPU = new System.Windows.Forms.Label();
            this.lbBSpeicherMB = new System.Windows.Forms.Label();
            this.lbBSpeicher = new System.Windows.Forms.Label();
            this.lbFSpeicherMB = new System.Windows.Forms.Label();
            this.lbFSpeicher = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbOrdner = new System.Windows.Forms.Label();
            this.panelMarker = new System.Windows.Forms.Panel();
            this.listMarker = new System.Windows.Forms.ListBox();
            this.lbMarker = new System.Windows.Forms.Label();
            this.panelÜberwachung = new System.Windows.Forms.Panel();
            this.lbTeamspeakStatus = new System.Windows.Forms.Label();
            this.lbDiscordSMStatus = new System.Windows.Forms.Label();
            this.lbSkypeStatus = new System.Windows.Forms.Label();
            this.lbDiscordSM = new System.Windows.Forms.Label();
            this.lbTeamSpeak = new System.Windows.Forms.Label();
            this.lbSkype = new System.Windows.Forms.Label();
            this.panelSoundÜberwachung = new System.Windows.Forms.Panel();
            this.listSoundüberwachung = new System.Windows.Forms.ListBox();
            this.lbSound = new System.Windows.Forms.Label();
            this.ShowPanelAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.ShowPanelsAnimation = new System.Windows.Forms.Timer(this.components);
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPause)).BeginInit();
            this.panelOrdner.SuspendLayout();
            this.panelMarker.SuspendLayout();
            this.panelÜberwachung.SuspendLayout();
            this.panelSoundÜberwachung.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bunifuImageButton2);
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.ShowPanelAnimator.SetDecoration(this.HeaderBar, BunifuAnimatorNS.DecorationType.None);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(445, 59);
            this.HeaderBar.TabIndex = 0;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowPanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(359, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowPanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(400, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // MinimaizeAnimation
            // 
            this.MinimaizeAnimation.Interval = 10;
            this.MinimaizeAnimation.Tick += new System.EventHandler(this.MinimaizeAnimation_Tick);
            // 
            // MaximaizeAnimation
            // 
            this.MaximaizeAnimation.Interval = 10;
            this.MaximaizeAnimation.Tick += new System.EventHandler(this.MaximaizeAnimation_Tick);
            // 
            // panelTimer
            // 
            this.panelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimer.Controls.Add(this.bPause);
            this.panelTimer.Controls.Add(this.bunifuCustomLabel1);
            this.ShowPanelAnimator.SetDecoration(this.panelTimer, BunifuAnimatorNS.DecorationType.None);
            this.panelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimer.Location = new System.Drawing.Point(0, 59);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(445, 171);
            this.panelTimer.TabIndex = 1;
            this.panelTimer.Visible = false;
            // 
            // bPause
            // 
            this.bPause.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShowPanelAnimator.SetDecoration(this.bPause, BunifuAnimatorNS.DecorationType.None);
            this.bPause.Image = ((System.Drawing.Image)(resources.GetObject("bPause.Image")));
            this.bPause.ImageActive = null;
            this.bPause.Location = new System.Drawing.Point(359, 95);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(58, 58);
            this.bPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bPause.TabIndex = 2;
            this.bPause.TabStop = false;
            this.bPause.Zoom = 10;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Windows Command Prompt", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(433, 76);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "00:00:00:00";
            // 
            // panelOrdner
            // 
            this.panelOrdner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrdner.Controls.Add(this.lbCPUAuslastung);
            this.panelOrdner.Controls.Add(this.lbCPU);
            this.panelOrdner.Controls.Add(this.lbBSpeicherMB);
            this.panelOrdner.Controls.Add(this.lbBSpeicher);
            this.panelOrdner.Controls.Add(this.lbFSpeicherMB);
            this.panelOrdner.Controls.Add(this.lbFSpeicher);
            this.panelOrdner.Controls.Add(this.lbPath);
            this.panelOrdner.Controls.Add(this.lbOrdner);
            this.ShowPanelAnimator.SetDecoration(this.panelOrdner, BunifuAnimatorNS.DecorationType.None);
            this.panelOrdner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdner.Location = new System.Drawing.Point(0, 230);
            this.panelOrdner.Name = "panelOrdner";
            this.panelOrdner.Size = new System.Drawing.Size(445, 171);
            this.panelOrdner.TabIndex = 2;
            this.panelOrdner.Visible = false;
            // 
            // lbCPUAuslastung
            // 
            this.lbCPUAuslastung.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbCPUAuslastung, BunifuAnimatorNS.DecorationType.None);
            this.lbCPUAuslastung.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPUAuslastung.ForeColor = System.Drawing.Color.White;
            this.lbCPUAuslastung.Location = new System.Drawing.Point(92, 116);
            this.lbCPUAuslastung.Name = "lbCPUAuslastung";
            this.lbCPUAuslastung.Size = new System.Drawing.Size(37, 18);
            this.lbCPUAuslastung.TabIndex = 7;
            this.lbCPUAuslastung.Text = "80%";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbCPU, BunifuAnimatorNS.DecorationType.None);
            this.lbCPU.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPU.ForeColor = System.Drawing.Color.White;
            this.lbCPU.Location = new System.Drawing.Point(38, 116);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(43, 18);
            this.lbCPU.TabIndex = 6;
            this.lbCPU.Text = "CPU:";
            // 
            // lbBSpeicherMB
            // 
            this.lbBSpeicherMB.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbBSpeicherMB, BunifuAnimatorNS.DecorationType.None);
            this.lbBSpeicherMB.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBSpeicherMB.ForeColor = System.Drawing.Color.White;
            this.lbBSpeicherMB.Location = new System.Drawing.Point(267, 74);
            this.lbBSpeicherMB.Name = "lbBSpeicherMB";
            this.lbBSpeicherMB.Size = new System.Drawing.Size(72, 18);
            this.lbBSpeicherMB.TabIndex = 5;
            this.lbBSpeicherMB.Text = "1400mB";
            // 
            // lbBSpeicher
            // 
            this.lbBSpeicher.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbBSpeicher, BunifuAnimatorNS.DecorationType.None);
            this.lbBSpeicher.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBSpeicher.ForeColor = System.Drawing.Color.White;
            this.lbBSpeicher.Location = new System.Drawing.Point(92, 73);
            this.lbBSpeicher.Name = "lbBSpeicher";
            this.lbBSpeicher.Size = new System.Drawing.Size(172, 18);
            this.lbBSpeicher.TabIndex = 4;
            this.lbBSpeicher.Text = "Belegter Speicher:";
            // 
            // lbFSpeicherMB
            // 
            this.lbFSpeicherMB.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbFSpeicherMB, BunifuAnimatorNS.DecorationType.None);
            this.lbFSpeicherMB.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFSpeicherMB.ForeColor = System.Drawing.Color.White;
            this.lbFSpeicherMB.Location = new System.Drawing.Point(252, 44);
            this.lbFSpeicherMB.Name = "lbFSpeicherMB";
            this.lbFSpeicherMB.Size = new System.Drawing.Size(70, 18);
            this.lbFSpeicherMB.TabIndex = 3;
            this.lbFSpeicherMB.Text = "1200mB";
            // 
            // lbFSpeicher
            // 
            this.lbFSpeicher.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbFSpeicher, BunifuAnimatorNS.DecorationType.None);
            this.lbFSpeicher.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFSpeicher.ForeColor = System.Drawing.Color.White;
            this.lbFSpeicher.Location = new System.Drawing.Point(92, 44);
            this.lbFSpeicher.Name = "lbFSpeicher";
            this.lbFSpeicher.Size = new System.Drawing.Size(154, 18);
            this.lbFSpeicher.TabIndex = 2;
            this.lbFSpeicher.Text = "Freier Speicher:";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbPath, BunifuAnimatorNS.DecorationType.None);
            this.lbPath.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.Color.White;
            this.lbPath.Location = new System.Drawing.Point(92, 12);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(249, 18);
            this.lbPath.TabIndex = 1;
            this.lbPath.Text = "D:\\OpenTools V2.0\\Aufnahme";
            // 
            // lbOrdner
            // 
            this.lbOrdner.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbOrdner, BunifuAnimatorNS.DecorationType.None);
            this.lbOrdner.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdner.ForeColor = System.Drawing.Color.White;
            this.lbOrdner.Location = new System.Drawing.Point(12, 12);
            this.lbOrdner.Name = "lbOrdner";
            this.lbOrdner.Size = new System.Drawing.Size(74, 18);
            this.lbOrdner.TabIndex = 0;
            this.lbOrdner.Text = "Ordner:";
            // 
            // panelMarker
            // 
            this.panelMarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMarker.Controls.Add(this.listMarker);
            this.panelMarker.Controls.Add(this.lbMarker);
            this.ShowPanelAnimator.SetDecoration(this.panelMarker, BunifuAnimatorNS.DecorationType.None);
            this.panelMarker.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarker.Location = new System.Drawing.Point(0, 401);
            this.panelMarker.Name = "panelMarker";
            this.panelMarker.Size = new System.Drawing.Size(445, 170);
            this.panelMarker.TabIndex = 6;
            this.panelMarker.Visible = false;
            // 
            // listMarker
            // 
            this.listMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listMarker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPanelAnimator.SetDecoration(this.listMarker, BunifuAnimatorNS.DecorationType.None);
            this.listMarker.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMarker.ForeColor = System.Drawing.Color.White;
            this.listMarker.FormattingEnabled = true;
            this.listMarker.ItemHeight = 18;
            this.listMarker.Items.AddRange(new object[] {
            "00:20:25:15",
            "",
            "00:50:50:50",
            "",
            "01:23:80:21"});
            this.listMarker.Location = new System.Drawing.Point(94, 12);
            this.listMarker.Name = "listMarker";
            this.listMarker.Size = new System.Drawing.Size(323, 144);
            this.listMarker.TabIndex = 1;
            // 
            // lbMarker
            // 
            this.lbMarker.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbMarker, BunifuAnimatorNS.DecorationType.None);
            this.lbMarker.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarker.ForeColor = System.Drawing.Color.White;
            this.lbMarker.Location = new System.Drawing.Point(12, 12);
            this.lbMarker.Name = "lbMarker";
            this.lbMarker.Size = new System.Drawing.Size(76, 18);
            this.lbMarker.TabIndex = 0;
            this.lbMarker.Text = "Marker:";
            // 
            // panelÜberwachung
            // 
            this.panelÜberwachung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelÜberwachung.Controls.Add(this.lbTeamspeakStatus);
            this.panelÜberwachung.Controls.Add(this.lbDiscordSMStatus);
            this.panelÜberwachung.Controls.Add(this.lbSkypeStatus);
            this.panelÜberwachung.Controls.Add(this.lbDiscordSM);
            this.panelÜberwachung.Controls.Add(this.lbTeamSpeak);
            this.panelÜberwachung.Controls.Add(this.lbSkype);
            this.ShowPanelAnimator.SetDecoration(this.panelÜberwachung, BunifuAnimatorNS.DecorationType.None);
            this.panelÜberwachung.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelÜberwachung.Location = new System.Drawing.Point(0, 571);
            this.panelÜberwachung.Name = "panelÜberwachung";
            this.panelÜberwachung.Size = new System.Drawing.Size(445, 170);
            this.panelÜberwachung.TabIndex = 7;
            this.panelÜberwachung.Visible = false;
            // 
            // lbTeamspeakStatus
            // 
            this.lbTeamspeakStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbTeamspeakStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbTeamspeakStatus.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamspeakStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTeamspeakStatus.Location = new System.Drawing.Point(228, 41);
            this.lbTeamspeakStatus.Name = "lbTeamspeakStatus";
            this.lbTeamspeakStatus.Size = new System.Drawing.Size(17, 18);
            this.lbTeamspeakStatus.TabIndex = 5;
            this.lbTeamspeakStatus.Text = "?";
            // 
            // lbDiscordSMStatus
            // 
            this.lbDiscordSMStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbDiscordSMStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbDiscordSMStatus.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscordSMStatus.ForeColor = System.Drawing.Color.Red;
            this.lbDiscordSMStatus.Location = new System.Drawing.Point(228, 73);
            this.lbDiscordSMStatus.Name = "lbDiscordSMStatus";
            this.lbDiscordSMStatus.Size = new System.Drawing.Size(37, 18);
            this.lbDiscordSMStatus.TabIndex = 4;
            this.lbDiscordSMStatus.Text = "Off";
            // 
            // lbSkypeStatus
            // 
            this.lbSkypeStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSkypeStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbSkypeStatus.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkypeStatus.ForeColor = System.Drawing.Color.Lime;
            this.lbSkypeStatus.Location = new System.Drawing.Point(228, 12);
            this.lbSkypeStatus.Name = "lbSkypeStatus";
            this.lbSkypeStatus.Size = new System.Drawing.Size(64, 18);
            this.lbSkypeStatus.TabIndex = 3;
            this.lbSkypeStatus.Text = "Online";
            // 
            // lbDiscordSM
            // 
            this.lbDiscordSM.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbDiscordSM, BunifuAnimatorNS.DecorationType.None);
            this.lbDiscordSM.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscordSM.ForeColor = System.Drawing.Color.White;
            this.lbDiscordSM.Location = new System.Drawing.Point(12, 73);
            this.lbDiscordSM.Name = "lbDiscordSM";
            this.lbDiscordSM.Size = new System.Drawing.Size(205, 18);
            this.lbDiscordSM.TabIndex = 2;
            this.lbDiscordSM.Text = "Discord Streamermode:";
            // 
            // lbTeamSpeak
            // 
            this.lbTeamSpeak.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbTeamSpeak, BunifuAnimatorNS.DecorationType.None);
            this.lbTeamSpeak.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamSpeak.ForeColor = System.Drawing.Color.White;
            this.lbTeamSpeak.Location = new System.Drawing.Point(11, 41);
            this.lbTeamSpeak.Name = "lbTeamSpeak";
            this.lbTeamSpeak.Size = new System.Drawing.Size(103, 18);
            this.lbTeamSpeak.TabIndex = 1;
            this.lbTeamSpeak.Text = "Teamspeak:";
            // 
            // lbSkype
            // 
            this.lbSkype.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSkype, BunifuAnimatorNS.DecorationType.None);
            this.lbSkype.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkype.ForeColor = System.Drawing.Color.White;
            this.lbSkype.Location = new System.Drawing.Point(12, 12);
            this.lbSkype.Name = "lbSkype";
            this.lbSkype.Size = new System.Drawing.Size(61, 18);
            this.lbSkype.TabIndex = 0;
            this.lbSkype.Text = "Skype:";
            // 
            // panelSoundÜberwachung
            // 
            this.panelSoundÜberwachung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSoundÜberwachung.Controls.Add(this.listSoundüberwachung);
            this.panelSoundÜberwachung.Controls.Add(this.lbSound);
            this.ShowPanelAnimator.SetDecoration(this.panelSoundÜberwachung, BunifuAnimatorNS.DecorationType.None);
            this.panelSoundÜberwachung.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSoundÜberwachung.Location = new System.Drawing.Point(0, 741);
            this.panelSoundÜberwachung.Name = "panelSoundÜberwachung";
            this.panelSoundÜberwachung.Size = new System.Drawing.Size(445, 170);
            this.panelSoundÜberwachung.TabIndex = 8;
            this.panelSoundÜberwachung.Visible = false;
            // 
            // listSoundüberwachung
            // 
            this.listSoundüberwachung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listSoundüberwachung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPanelAnimator.SetDecoration(this.listSoundüberwachung, BunifuAnimatorNS.DecorationType.None);
            this.listSoundüberwachung.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSoundüberwachung.ForeColor = System.Drawing.Color.White;
            this.listSoundüberwachung.FormattingEnabled = true;
            this.listSoundüberwachung.ItemHeight = 18;
            this.listSoundüberwachung.Items.AddRange(new object[] {
            "Chrome",
            "Minecraft 1.9",
            "Skype",
            "Windows Media Player"});
            this.listSoundüberwachung.Location = new System.Drawing.Point(11, 41);
            this.listSoundüberwachung.Name = "listSoundüberwachung";
            this.listSoundüberwachung.Size = new System.Drawing.Size(382, 126);
            this.listSoundüberwachung.TabIndex = 2;
            // 
            // lbSound
            // 
            this.lbSound.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSound, BunifuAnimatorNS.DecorationType.None);
            this.lbSound.Font = new System.Drawing.Font("Windows Command Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSound.ForeColor = System.Drawing.Color.White;
            this.lbSound.Location = new System.Drawing.Point(12, 12);
            this.lbSound.Name = "lbSound";
            this.lbSound.Size = new System.Drawing.Size(393, 18);
            this.lbSound.TabIndex = 0;
            this.lbSound.Text = "Diese Programme könnten Sound verursachen:\r\n";
            // 
            // ShowPanelAnimator
            // 
            this.ShowPanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.ShowPanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.ShowPanelAnimator.DefaultAnimation = animation2;
            this.ShowPanelAnimator.Interval = 5;
            // 
            // ShowPanelsAnimation
            // 
            this.ShowPanelsAnimation.Interval = 150;
            this.ShowPanelsAnimation.Tick += new System.EventHandler(this.ShowPanelsAnimation_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(445, 911);
            this.Controls.Add(this.panelSoundÜberwachung);
            this.Controls.Add(this.panelÜberwachung);
            this.Controls.Add(this.panelMarker);
            this.Controls.Add(this.panelOrdner);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.HeaderBar);
            this.ShowPanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.HeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPause)).EndInit();
            this.panelOrdner.ResumeLayout(false);
            this.panelOrdner.PerformLayout();
            this.panelMarker.ResumeLayout(false);
            this.panelMarker.PerformLayout();
            this.panelÜberwachung.ResumeLayout(false);
            this.panelÜberwachung.PerformLayout();
            this.panelSoundÜberwachung.ResumeLayout(false);
            this.panelSoundÜberwachung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer MinimaizeAnimation;
        private System.Windows.Forms.Timer MaximaizeAnimation;
        private System.Windows.Forms.Panel panelTimer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bPause;
        private System.Windows.Forms.Panel panelOrdner;
        private System.Windows.Forms.Label lbBSpeicherMB;
        private System.Windows.Forms.Label lbBSpeicher;
        private System.Windows.Forms.Label lbFSpeicherMB;
        private System.Windows.Forms.Label lbFSpeicher;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbOrdner;
        private System.Windows.Forms.Panel panelMarker;
        private System.Windows.Forms.ListBox listMarker;
        private System.Windows.Forms.Label lbMarker;
        private System.Windows.Forms.Label lbCPUAuslastung;
        private System.Windows.Forms.Label lbCPU;
        private System.Windows.Forms.Panel panelÜberwachung;
        private System.Windows.Forms.Label lbSkype;
        private System.Windows.Forms.Label lbTeamspeakStatus;
        private System.Windows.Forms.Label lbDiscordSMStatus;
        private System.Windows.Forms.Label lbSkypeStatus;
        private System.Windows.Forms.Label lbDiscordSM;
        private System.Windows.Forms.Label lbTeamSpeak;
        private System.Windows.Forms.Panel panelSoundÜberwachung;
        private System.Windows.Forms.ListBox listSoundüberwachung;
        private System.Windows.Forms.Label lbSound;
        private BunifuAnimatorNS.Animator ShowPanelAnimator;
        private System.Windows.Forms.Timer ShowPanelsAnimation;
    }
}


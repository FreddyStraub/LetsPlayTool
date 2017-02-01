using BunifuAnimatorNS;

namespace LetsPlayTool
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.bShowÜFenster = new Bunifu.Framework.UI.BunifuImageButton();
            this.bSettings = new Bunifu.Framework.UI.BunifuImageButton();
            this.bOpenPrograms = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimaizeAnimation = new System.Windows.Forms.Timer(this.components);
            this.MaximaizeAnimation = new System.Windows.Forms.Timer(this.components);
            this.panelTimer = new System.Windows.Forms.Panel();
            this.labelTimer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelOrdner = new System.Windows.Forms.Panel();
            this.lbUPUsage = new System.Windows.Forms.Label();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbDownUsage = new System.Windows.Forms.Label();
            this.lbDown = new System.Windows.Forms.Label();
            this.lbRAMUsed = new System.Windows.Forms.Label();
            this.lbRAM = new System.Windows.Forms.Label();
            this.lbCPUAuslastung = new System.Windows.Forms.Label();
            this.lbCPU = new System.Windows.Forms.Label();
            this.lbBSpeicherGB = new System.Windows.Forms.Label();
            this.lbBSpeicher = new System.Windows.Forms.Label();
            this.lbFSpeicherGB = new System.Windows.Forms.Label();
            this.lbFSpeicher = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbOrdner = new System.Windows.Forms.Label();
            this.panelMarker = new System.Windows.Forms.Panel();
            this.listMarker = new System.Windows.Forms.ListBox();
            this.lbMarker = new System.Windows.Forms.Label();
            this.panelÜberwachung = new System.Windows.Forms.Panel();
            this.panelSteam = new System.Windows.Forms.Panel();
            this.lbSteam = new System.Windows.Forms.Label();
            this.lbSteamStatus = new System.Windows.Forms.Label();
            this.panelMail = new System.Windows.Forms.Panel();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbMailClient = new System.Windows.Forms.Label();
            this.panelDiscord = new System.Windows.Forms.Panel();
            this.lbDiscordSM = new System.Windows.Forms.Label();
            this.lbDiscordSMStatus = new System.Windows.Forms.Label();
            this.panelTeamspeak = new System.Windows.Forms.Panel();
            this.lbTeamSpeak = new System.Windows.Forms.Label();
            this.lbTeamspeakStatus = new System.Windows.Forms.Label();
            this.panelSkype = new System.Windows.Forms.Panel();
            this.lbSkype = new System.Windows.Forms.Label();
            this.lbSkypeStatus = new System.Windows.Forms.Label();
            this.panelSoundÜberwachung = new System.Windows.Forms.Panel();
            this.sliderLautsprecher = new Bunifu.Framework.UI.BunifuTrackbar();
            this.lbLautsprecher = new System.Windows.Forms.Label();
            this.ShowPanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ShowPanelsAnimation = new System.Windows.Forms.Timer(this.components);
            this.Mainactor = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ValueUpdater = new System.Windows.Forms.Timer(this.components);
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bShowÜFenster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOpenPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelTimer.SuspendLayout();
            this.panelOrdner.SuspendLayout();
            this.panelMarker.SuspendLayout();
            this.panelÜberwachung.SuspendLayout();
            this.panelSteam.SuspendLayout();
            this.panelMail.SuspendLayout();
            this.panelDiscord.SuspendLayout();
            this.panelTeamspeak.SuspendLayout();
            this.panelSkype.SuspendLayout();
            this.panelSoundÜberwachung.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bShowÜFenster);
            this.HeaderBar.Controls.Add(this.bSettings);
            this.HeaderBar.Controls.Add(this.bOpenPrograms);
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
            // bShowÜFenster
            // 
            this.bShowÜFenster.BackColor = System.Drawing.Color.Transparent;
            this.bShowÜFenster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPanelAnimator.SetDecoration(this.bShowÜFenster, BunifuAnimatorNS.DecorationType.None);
            this.bShowÜFenster.Image = ((System.Drawing.Image)(resources.GetObject("bShowÜFenster.Image")));
            this.bShowÜFenster.ImageActive = null;
            this.bShowÜFenster.Location = new System.Drawing.Point(94, 12);
            this.bShowÜFenster.Name = "bShowÜFenster";
            this.bShowÜFenster.Size = new System.Drawing.Size(35, 35);
            this.bShowÜFenster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bShowÜFenster.TabIndex = 5;
            this.bShowÜFenster.TabStop = false;
            this.toolTip1.SetToolTip(this.bShowÜFenster, "Überwachungsfenster anzeigen");
            this.bShowÜFenster.Zoom = 5;
            this.bShowÜFenster.Click += new System.EventHandler(this.bOpenÜFenster_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.Transparent;
            this.bSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPanelAnimator.SetDecoration(this.bSettings, BunifuAnimatorNS.DecorationType.None);
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.ImageActive = null;
            this.bSettings.Location = new System.Drawing.Point(53, 12);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(35, 35);
            this.bSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bSettings.TabIndex = 4;
            this.bSettings.TabStop = false;
            this.bSettings.Zoom = 5;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // bOpenPrograms
            // 
            this.bOpenPrograms.BackColor = System.Drawing.Color.Transparent;
            this.bOpenPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPanelAnimator.SetDecoration(this.bOpenPrograms, BunifuAnimatorNS.DecorationType.None);
            this.bOpenPrograms.Image = ((System.Drawing.Image)(resources.GetObject("bOpenPrograms.Image")));
            this.bOpenPrograms.ImageActive = null;
            this.bOpenPrograms.Location = new System.Drawing.Point(12, 12);
            this.bOpenPrograms.Name = "bOpenPrograms";
            this.bOpenPrograms.Size = new System.Drawing.Size(35, 35);
            this.bOpenPrograms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bOpenPrograms.TabIndex = 3;
            this.bOpenPrograms.TabStop = false;
            this.bOpenPrograms.Zoom = 5;
            this.bOpenPrograms.Click += new System.EventHandler(this.bOpenPrograms_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.panelTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimer.Controls.Add(this.labelTimer);
            this.ShowPanelAnimator.SetDecoration(this.panelTimer, BunifuAnimatorNS.DecorationType.None);
            this.panelTimer.Location = new System.Drawing.Point(0, 59);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(445, 133);
            this.panelTimer.TabIndex = 1;
            this.panelTimer.Visible = false;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ShowPanelAnimator.SetDecoration(this.labelTimer, BunifuAnimatorNS.DecorationType.None);
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(15, 16);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(402, 98);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00:00:00:00";
            this.labelTimer.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            this.labelTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomLabel1_MouseDown);
            // 
            // panelOrdner
            // 
            this.panelOrdner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelOrdner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrdner.Controls.Add(this.lbUPUsage);
            this.panelOrdner.Controls.Add(this.lbUp);
            this.panelOrdner.Controls.Add(this.lbDownUsage);
            this.panelOrdner.Controls.Add(this.lbDown);
            this.panelOrdner.Controls.Add(this.lbRAMUsed);
            this.panelOrdner.Controls.Add(this.lbRAM);
            this.panelOrdner.Controls.Add(this.lbCPUAuslastung);
            this.panelOrdner.Controls.Add(this.lbCPU);
            this.panelOrdner.Controls.Add(this.lbBSpeicherGB);
            this.panelOrdner.Controls.Add(this.lbBSpeicher);
            this.panelOrdner.Controls.Add(this.lbFSpeicherGB);
            this.panelOrdner.Controls.Add(this.lbFSpeicher);
            this.panelOrdner.Controls.Add(this.lbPath);
            this.panelOrdner.Controls.Add(this.lbOrdner);
            this.ShowPanelAnimator.SetDecoration(this.panelOrdner, BunifuAnimatorNS.DecorationType.None);
            this.panelOrdner.Location = new System.Drawing.Point(0, 192);
            this.panelOrdner.Name = "panelOrdner";
            this.panelOrdner.Size = new System.Drawing.Size(445, 167);
            this.panelOrdner.TabIndex = 2;
            this.panelOrdner.Visible = false;
            // 
            // lbUPUsage
            // 
            this.lbUPUsage.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbUPUsage, BunifuAnimatorNS.DecorationType.None);
            this.lbUPUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUPUsage.ForeColor = System.Drawing.Color.White;
            this.lbUPUsage.Location = new System.Drawing.Point(340, 122);
            this.lbUPUsage.Name = "lbUPUsage";
            this.lbUPUsage.Size = new System.Drawing.Size(19, 21);
            this.lbUPUsage.TabIndex = 13;
            this.lbUPUsage.Text = "...";
            // 
            // lbUp
            // 
            this.lbUp.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbUp, BunifuAnimatorNS.DecorationType.None);
            this.lbUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUp.ForeColor = System.Drawing.Color.White;
            this.lbUp.Location = new System.Drawing.Point(249, 122);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(82, 21);
            this.lbUp.TabIndex = 12;
            this.lbUp.Text = "UpStream:";
            // 
            // lbDownUsage
            // 
            this.lbDownUsage.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbDownUsage, BunifuAnimatorNS.DecorationType.None);
            this.lbDownUsage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownUsage.ForeColor = System.Drawing.Color.White;
            this.lbDownUsage.Location = new System.Drawing.Point(127, 122);
            this.lbDownUsage.Name = "lbDownUsage";
            this.lbDownUsage.Size = new System.Drawing.Size(19, 21);
            this.lbDownUsage.TabIndex = 11;
            this.lbDownUsage.Text = "...";
            // 
            // lbDown
            // 
            this.lbDown.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbDown, BunifuAnimatorNS.DecorationType.None);
            this.lbDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDown.ForeColor = System.Drawing.Color.White;
            this.lbDown.Location = new System.Drawing.Point(18, 122);
            this.lbDown.Name = "lbDown";
            this.lbDown.Size = new System.Drawing.Size(103, 21);
            this.lbDown.TabIndex = 10;
            this.lbDown.Text = "DownStream:";
            // 
            // lbRAMUsed
            // 
            this.lbRAMUsed.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbRAMUsed, BunifuAnimatorNS.DecorationType.None);
            this.lbRAMUsed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRAMUsed.ForeColor = System.Drawing.Color.White;
            this.lbRAMUsed.Location = new System.Drawing.Point(337, 79);
            this.lbRAMUsed.Name = "lbRAMUsed";
            this.lbRAMUsed.Size = new System.Drawing.Size(19, 21);
            this.lbRAMUsed.TabIndex = 9;
            this.lbRAMUsed.Text = "...";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbRAM, BunifuAnimatorNS.DecorationType.None);
            this.lbRAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRAM.ForeColor = System.Drawing.Color.White;
            this.lbRAM.Location = new System.Drawing.Point(249, 79);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(91, 21);
            this.lbRAM.TabIndex = 8;
            this.lbRAM.Text = "Freier RAM:";
            // 
            // lbCPUAuslastung
            // 
            this.lbCPUAuslastung.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbCPUAuslastung, BunifuAnimatorNS.DecorationType.None);
            this.lbCPUAuslastung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPUAuslastung.ForeColor = System.Drawing.Color.White;
            this.lbCPUAuslastung.Location = new System.Drawing.Point(290, 49);
            this.lbCPUAuslastung.Name = "lbCPUAuslastung";
            this.lbCPUAuslastung.Size = new System.Drawing.Size(19, 21);
            this.lbCPUAuslastung.TabIndex = 7;
            this.lbCPUAuslastung.Text = "...";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbCPU, BunifuAnimatorNS.DecorationType.None);
            this.lbCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPU.ForeColor = System.Drawing.Color.White;
            this.lbCPU.Location = new System.Drawing.Point(249, 49);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(43, 21);
            this.lbCPU.TabIndex = 6;
            this.lbCPU.Text = "CPU:";
            // 
            // lbBSpeicherGB
            // 
            this.lbBSpeicherGB.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbBSpeicherGB, BunifuAnimatorNS.DecorationType.None);
            this.lbBSpeicherGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBSpeicherGB.ForeColor = System.Drawing.Color.White;
            this.lbBSpeicherGB.Location = new System.Drawing.Point(168, 79);
            this.lbBSpeicherGB.Name = "lbBSpeicherGB";
            this.lbBSpeicherGB.Size = new System.Drawing.Size(19, 21);
            this.lbBSpeicherGB.TabIndex = 5;
            this.lbBSpeicherGB.Text = "...";
            // 
            // lbBSpeicher
            // 
            this.lbBSpeicher.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbBSpeicher, BunifuAnimatorNS.DecorationType.None);
            this.lbBSpeicher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBSpeicher.ForeColor = System.Drawing.Color.White;
            this.lbBSpeicher.Location = new System.Drawing.Point(18, 78);
            this.lbBSpeicher.Name = "lbBSpeicher";
            this.lbBSpeicher.Size = new System.Drawing.Size(134, 21);
            this.lbBSpeicher.TabIndex = 4;
            this.lbBSpeicher.Text = "Belegter Speicher:";
            // 
            // lbFSpeicherGB
            // 
            this.lbFSpeicherGB.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbFSpeicherGB, BunifuAnimatorNS.DecorationType.None);
            this.lbFSpeicherGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFSpeicherGB.ForeColor = System.Drawing.Color.White;
            this.lbFSpeicherGB.Location = new System.Drawing.Point(168, 49);
            this.lbFSpeicherGB.Name = "lbFSpeicherGB";
            this.lbFSpeicherGB.Size = new System.Drawing.Size(19, 21);
            this.lbFSpeicherGB.TabIndex = 3;
            this.lbFSpeicherGB.Text = "...";
            // 
            // lbFSpeicher
            // 
            this.lbFSpeicher.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbFSpeicher, BunifuAnimatorNS.DecorationType.None);
            this.lbFSpeicher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFSpeicher.ForeColor = System.Drawing.Color.White;
            this.lbFSpeicher.Location = new System.Drawing.Point(18, 49);
            this.lbFSpeicher.Name = "lbFSpeicher";
            this.lbFSpeicher.Size = new System.Drawing.Size(117, 21);
            this.lbFSpeicher.TabIndex = 2;
            this.lbFSpeicher.Text = "Freier Speicher:";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbPath, BunifuAnimatorNS.DecorationType.None);
            this.lbPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.Color.White;
            this.lbPath.Location = new System.Drawing.Point(92, 12);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(328, 21);
            this.lbPath.TabIndex = 1;
            this.lbPath.Text = "D:\\OpenTools V2.0\\Aufnahmeaaaaaaaaaaaaaa";
            this.lbPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lbPath, "Überwachungsordner");
            // 
            // lbOrdner
            // 
            this.lbOrdner.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbOrdner, BunifuAnimatorNS.DecorationType.None);
            this.lbOrdner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdner.ForeColor = System.Drawing.Color.White;
            this.lbOrdner.Location = new System.Drawing.Point(12, 12);
            this.lbOrdner.Name = "lbOrdner";
            this.lbOrdner.Size = new System.Drawing.Size(63, 21);
            this.lbOrdner.TabIndex = 0;
            this.lbOrdner.Text = "Ordner:";
            // 
            // panelMarker
            // 
            this.panelMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelMarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMarker.Controls.Add(this.listMarker);
            this.panelMarker.Controls.Add(this.lbMarker);
            this.ShowPanelAnimator.SetDecoration(this.panelMarker, BunifuAnimatorNS.DecorationType.None);
            this.panelMarker.Location = new System.Drawing.Point(0, 358);
            this.panelMarker.Name = "panelMarker";
            this.panelMarker.Size = new System.Drawing.Size(445, 99);
            this.panelMarker.TabIndex = 6;
            this.panelMarker.Visible = false;
            // 
            // listMarker
            // 
            this.listMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.listMarker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPanelAnimator.SetDecoration(this.listMarker, BunifuAnimatorNS.DecorationType.None);
            this.listMarker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMarker.ForeColor = System.Drawing.Color.White;
            this.listMarker.FormattingEnabled = true;
            this.listMarker.ItemHeight = 21;
            this.listMarker.Location = new System.Drawing.Point(94, 11);
            this.listMarker.Name = "listMarker";
            this.listMarker.Size = new System.Drawing.Size(323, 105);
            this.listMarker.TabIndex = 1;
            this.toolTip1.SetToolTip(this.listMarker, "Erstellte Marker in dieser Session");
            // 
            // lbMarker
            // 
            this.lbMarker.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbMarker, BunifuAnimatorNS.DecorationType.None);
            this.lbMarker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarker.ForeColor = System.Drawing.Color.White;
            this.lbMarker.Location = new System.Drawing.Point(12, 11);
            this.lbMarker.Name = "lbMarker";
            this.lbMarker.Size = new System.Drawing.Size(63, 21);
            this.lbMarker.TabIndex = 0;
            this.lbMarker.Text = "Marker:";
            // 
            // panelÜberwachung
            // 
            this.panelÜberwachung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelÜberwachung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelÜberwachung.Controls.Add(this.panelSteam);
            this.panelÜberwachung.Controls.Add(this.panelMail);
            this.panelÜberwachung.Controls.Add(this.panelDiscord);
            this.panelÜberwachung.Controls.Add(this.panelTeamspeak);
            this.panelÜberwachung.Controls.Add(this.panelSkype);
            this.ShowPanelAnimator.SetDecoration(this.panelÜberwachung, BunifuAnimatorNS.DecorationType.None);
            this.panelÜberwachung.Location = new System.Drawing.Point(0, 457);
            this.panelÜberwachung.Name = "panelÜberwachung";
            this.panelÜberwachung.Size = new System.Drawing.Size(445, 198);
            this.panelÜberwachung.TabIndex = 7;
            this.panelÜberwachung.Visible = false;
            // 
            // panelSteam
            // 
            this.panelSteam.Controls.Add(this.lbSteam);
            this.panelSteam.Controls.Add(this.lbSteamStatus);
            this.ShowPanelAnimator.SetDecoration(this.panelSteam, BunifuAnimatorNS.DecorationType.None);
            this.panelSteam.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSteam.Location = new System.Drawing.Point(0, 156);
            this.panelSteam.Name = "panelSteam";
            this.panelSteam.Size = new System.Drawing.Size(443, 39);
            this.panelSteam.TabIndex = 10;
            // 
            // lbSteam
            // 
            this.lbSteam.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSteam, BunifuAnimatorNS.DecorationType.None);
            this.lbSteam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSteam.ForeColor = System.Drawing.Color.White;
            this.lbSteam.Location = new System.Drawing.Point(13, 8);
            this.lbSteam.Name = "lbSteam";
            this.lbSteam.Size = new System.Drawing.Size(56, 21);
            this.lbSteam.TabIndex = 8;
            this.lbSteam.Text = "Steam:";
            // 
            // lbSteamStatus
            // 
            this.lbSteamStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSteamStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbSteamStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSteamStatus.ForeColor = System.Drawing.Color.White;
            this.lbSteamStatus.Location = new System.Drawing.Point(230, 8);
            this.lbSteamStatus.Name = "lbSteamStatus";
            this.lbSteamStatus.Size = new System.Drawing.Size(19, 21);
            this.lbSteamStatus.TabIndex = 9;
            this.lbSteamStatus.Text = "...";
            this.toolTip1.SetToolTip(this.lbSteamStatus, "Status");
            // 
            // panelMail
            // 
            this.panelMail.Controls.Add(this.lbMail);
            this.panelMail.Controls.Add(this.lbMailClient);
            this.ShowPanelAnimator.SetDecoration(this.panelMail, BunifuAnimatorNS.DecorationType.None);
            this.panelMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMail.Location = new System.Drawing.Point(0, 117);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(443, 39);
            this.panelMail.TabIndex = 13;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbMail, BunifuAnimatorNS.DecorationType.None);
            this.lbMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.ForeColor = System.Drawing.Color.White;
            this.lbMail.Location = new System.Drawing.Point(13, 10);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(43, 21);
            this.lbMail.TabIndex = 6;
            this.lbMail.Text = "Mail:";
            // 
            // lbMailClient
            // 
            this.lbMailClient.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbMailClient, BunifuAnimatorNS.DecorationType.None);
            this.lbMailClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMailClient.ForeColor = System.Drawing.Color.White;
            this.lbMailClient.Location = new System.Drawing.Point(229, 10);
            this.lbMailClient.Name = "lbMailClient";
            this.lbMailClient.Size = new System.Drawing.Size(19, 21);
            this.lbMailClient.TabIndex = 7;
            this.lbMailClient.Text = "...";
            this.toolTip1.SetToolTip(this.lbMailClient, "Status");
            // 
            // panelDiscord
            // 
            this.panelDiscord.Controls.Add(this.lbDiscordSM);
            this.panelDiscord.Controls.Add(this.lbDiscordSMStatus);
            this.ShowPanelAnimator.SetDecoration(this.panelDiscord, BunifuAnimatorNS.DecorationType.None);
            this.panelDiscord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiscord.Location = new System.Drawing.Point(0, 78);
            this.panelDiscord.Name = "panelDiscord";
            this.panelDiscord.Size = new System.Drawing.Size(443, 39);
            this.panelDiscord.TabIndex = 12;
            // 
            // lbDiscordSM
            // 
            this.lbDiscordSM.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbDiscordSM, BunifuAnimatorNS.DecorationType.None);
            this.lbDiscordSM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscordSM.ForeColor = System.Drawing.Color.White;
            this.lbDiscordSM.Location = new System.Drawing.Point(12, 10);
            this.lbDiscordSM.Name = "lbDiscordSM";
            this.lbDiscordSM.Size = new System.Drawing.Size(66, 21);
            this.lbDiscordSM.TabIndex = 2;
            this.lbDiscordSM.Text = "Discord:";
            // 
            // lbDiscordSMStatus
            // 
            this.lbDiscordSMStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbDiscordSMStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbDiscordSMStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscordSMStatus.ForeColor = System.Drawing.Color.White;
            this.lbDiscordSMStatus.Location = new System.Drawing.Point(228, 10);
            this.lbDiscordSMStatus.Name = "lbDiscordSMStatus";
            this.lbDiscordSMStatus.Size = new System.Drawing.Size(19, 21);
            this.lbDiscordSMStatus.TabIndex = 4;
            this.lbDiscordSMStatus.Text = "...";
            this.toolTip1.SetToolTip(this.lbDiscordSMStatus, "Status");
            // 
            // panelTeamspeak
            // 
            this.panelTeamspeak.Controls.Add(this.lbTeamSpeak);
            this.panelTeamspeak.Controls.Add(this.lbTeamspeakStatus);
            this.ShowPanelAnimator.SetDecoration(this.panelTeamspeak, BunifuAnimatorNS.DecorationType.None);
            this.panelTeamspeak.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTeamspeak.Location = new System.Drawing.Point(0, 39);
            this.panelTeamspeak.Name = "panelTeamspeak";
            this.panelTeamspeak.Size = new System.Drawing.Size(443, 39);
            this.panelTeamspeak.TabIndex = 11;
            // 
            // lbTeamSpeak
            // 
            this.lbTeamSpeak.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbTeamSpeak, BunifuAnimatorNS.DecorationType.None);
            this.lbTeamSpeak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamSpeak.ForeColor = System.Drawing.Color.White;
            this.lbTeamSpeak.Location = new System.Drawing.Point(12, 9);
            this.lbTeamSpeak.Name = "lbTeamSpeak";
            this.lbTeamSpeak.Size = new System.Drawing.Size(89, 21);
            this.lbTeamSpeak.TabIndex = 1;
            this.lbTeamSpeak.Text = "Teamspeak:";
            // 
            // lbTeamspeakStatus
            // 
            this.lbTeamspeakStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbTeamspeakStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbTeamspeakStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamspeakStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTeamspeakStatus.Location = new System.Drawing.Point(229, 9);
            this.lbTeamspeakStatus.Name = "lbTeamspeakStatus";
            this.lbTeamspeakStatus.Size = new System.Drawing.Size(19, 21);
            this.lbTeamspeakStatus.TabIndex = 5;
            this.lbTeamspeakStatus.Text = "...";
            this.toolTip1.SetToolTip(this.lbTeamspeakStatus, "Status");
            // 
            // panelSkype
            // 
            this.panelSkype.Controls.Add(this.lbSkype);
            this.panelSkype.Controls.Add(this.lbSkypeStatus);
            this.ShowPanelAnimator.SetDecoration(this.panelSkype, BunifuAnimatorNS.DecorationType.None);
            this.panelSkype.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSkype.Location = new System.Drawing.Point(0, 0);
            this.panelSkype.Name = "panelSkype";
            this.panelSkype.Size = new System.Drawing.Size(443, 39);
            this.panelSkype.TabIndex = 10;
            // 
            // lbSkype
            // 
            this.lbSkype.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSkype, BunifuAnimatorNS.DecorationType.None);
            this.lbSkype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkype.ForeColor = System.Drawing.Color.White;
            this.lbSkype.Location = new System.Drawing.Point(13, 8);
            this.lbSkype.Name = "lbSkype";
            this.lbSkype.Size = new System.Drawing.Size(55, 21);
            this.lbSkype.TabIndex = 0;
            this.lbSkype.Text = "Skype:";
            // 
            // lbSkypeStatus
            // 
            this.lbSkypeStatus.AutoSize = true;
            this.ShowPanelAnimator.SetDecoration(this.lbSkypeStatus, BunifuAnimatorNS.DecorationType.None);
            this.lbSkypeStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkypeStatus.ForeColor = System.Drawing.Color.Lime;
            this.lbSkypeStatus.Location = new System.Drawing.Point(229, 8);
            this.lbSkypeStatus.Name = "lbSkypeStatus";
            this.lbSkypeStatus.Size = new System.Drawing.Size(19, 21);
            this.lbSkypeStatus.TabIndex = 3;
            this.lbSkypeStatus.Text = "...";
            this.toolTip1.SetToolTip(this.lbSkypeStatus, "Status");
            this.lbSkypeStatus.TextChanged += new System.EventHandler(this.lbSkypeStatus_TextChanged);
            // 
            // panelSoundÜberwachung
            // 
            this.panelSoundÜberwachung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelSoundÜberwachung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSoundÜberwachung.Controls.Add(this.sliderLautsprecher);
            this.panelSoundÜberwachung.Controls.Add(this.lbLautsprecher);
            this.ShowPanelAnimator.SetDecoration(this.panelSoundÜberwachung, BunifuAnimatorNS.DecorationType.None);
            this.panelSoundÜberwachung.Location = new System.Drawing.Point(0, 650);
            this.panelSoundÜberwachung.Name = "panelSoundÜberwachung";
            this.panelSoundÜberwachung.Size = new System.Drawing.Size(445, 74);
            this.panelSoundÜberwachung.TabIndex = 8;
            this.panelSoundÜberwachung.Visible = false;
            // 
            // sliderLautsprecher
            // 
            this.sliderLautsprecher.BackColor = System.Drawing.Color.Transparent;
            this.sliderLautsprecher.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.sliderLautsprecher.BorderRadius = 0;
            this.ShowPanelAnimator.SetDecoration(this.sliderLautsprecher, BunifuAnimatorNS.DecorationType.None);
            this.sliderLautsprecher.IndicatorColor = System.Drawing.Color.DodgerBlue;
            this.sliderLautsprecher.Location = new System.Drawing.Point(122, 23);
            this.sliderLautsprecher.MaximumValue = 100;
            this.sliderLautsprecher.Name = "sliderLautsprecher";
            this.sliderLautsprecher.Size = new System.Drawing.Size(298, 30);
            this.sliderLautsprecher.SliderRadius = 0;
            this.sliderLautsprecher.TabIndex = 6;
            this.sliderLautsprecher.Value = 0;
            this.sliderLautsprecher.ValueChanged += new System.EventHandler(this.sliderLautsprecher_ValueChanged);
            // 
            // lbLautsprecher
            // 
            this.lbLautsprecher.AutoSize = true;
            this.lbLautsprecher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPanelAnimator.SetDecoration(this.lbLautsprecher, BunifuAnimatorNS.DecorationType.None);
            this.lbLautsprecher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLautsprecher.ForeColor = System.Drawing.Color.White;
            this.lbLautsprecher.Location = new System.Drawing.Point(13, 23);
            this.lbLautsprecher.Name = "lbLautsprecher";
            this.lbLautsprecher.Size = new System.Drawing.Size(103, 21);
            this.lbLautsprecher.TabIndex = 4;
            this.lbLautsprecher.Text = "Lautsprecher:";
            // 
            // ShowPanelAnimator
            // 
            this.ShowPanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.ShowPanelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.ShowPanelAnimator.DefaultAnimation = animation4;
            this.ShowPanelAnimator.Interval = 5;
            // 
            // ShowPanelsAnimation
            // 
            this.ShowPanelsAnimation.Interval = 120;
            this.ShowPanelsAnimation.Tick += new System.EventHandler(this.ShowPanelsAnimation_Tick);
            // 
            // Mainactor
            // 
            this.Mainactor.Interval = 1;
            this.Mainactor.Tick += new System.EventHandler(this.Mainactor_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            // 
            // ValueUpdater
            // 
            this.ValueUpdater.Interval = 1000;
            this.ValueUpdater.Tick += new System.EventHandler(this.ValueUpdater_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(445, 724);
            this.Controls.Add(this.panelSoundÜberwachung);
            this.Controls.Add(this.panelÜberwachung);
            this.Controls.Add(this.panelMarker);
            this.Controls.Add(this.panelOrdner);
            this.Controls.Add(this.panelTimer);
            this.Controls.Add(this.HeaderBar);
            this.ShowPanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(445, 724);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LetsPlayTool by Wolf066LP";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.HeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bShowÜFenster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOpenPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            this.panelOrdner.ResumeLayout(false);
            this.panelOrdner.PerformLayout();
            this.panelMarker.ResumeLayout(false);
            this.panelMarker.PerformLayout();
            this.panelÜberwachung.ResumeLayout(false);
            this.panelSteam.ResumeLayout(false);
            this.panelSteam.PerformLayout();
            this.panelMail.ResumeLayout(false);
            this.panelMail.PerformLayout();
            this.panelDiscord.ResumeLayout(false);
            this.panelDiscord.PerformLayout();
            this.panelTeamspeak.ResumeLayout(false);
            this.panelTeamspeak.PerformLayout();
            this.panelSkype.ResumeLayout(false);
            this.panelSkype.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuCustomLabel labelTimer;
        private System.Windows.Forms.Panel panelOrdner;
        private System.Windows.Forms.Label lbBSpeicherGB;
        private System.Windows.Forms.Label lbBSpeicher;
        private System.Windows.Forms.Label lbFSpeicherGB;
        private System.Windows.Forms.Label lbFSpeicher;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbOrdner;
        private System.Windows.Forms.Panel panelMarker;
        private System.Windows.Forms.ListBox listMarker;
        private System.Windows.Forms.Label lbMarker;
        private System.Windows.Forms.Label lbCPUAuslastung;
        private System.Windows.Forms.Label lbCPU;
        private System.Windows.Forms.Panel panelÜberwachung;
        private System.Windows.Forms.Label lbTeamspeakStatus;
        private System.Windows.Forms.Label lbDiscordSMStatus;
        private System.Windows.Forms.Label lbDiscordSM;
        private System.Windows.Forms.Label lbTeamSpeak;
        private System.Windows.Forms.Panel panelSoundÜberwachung;
        private BunifuAnimatorNS.BunifuTransition ShowPanelAnimator;
        private System.Windows.Forms.Timer ShowPanelsAnimation;
        private Bunifu.Framework.UI.BunifuImageButton bOpenPrograms;
        private Bunifu.Framework.UI.BunifuImageButton bSettings;
        private System.Windows.Forms.Label lbRAMUsed;
        private System.Windows.Forms.Label lbRAM;
        private System.Windows.Forms.Timer Mainactor;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton bShowÜFenster;
        private System.Windows.Forms.Label lbLautsprecher;
        private Bunifu.Framework.UI.BunifuTrackbar sliderLautsprecher;
        public System.Windows.Forms.Timer ValueUpdater;
        private System.Windows.Forms.Label lbMailClient;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbSteamStatus;
        private System.Windows.Forms.Label lbSteam;
        private System.Windows.Forms.Panel panelSteam;
        private System.Windows.Forms.Panel panelMail;
        private System.Windows.Forms.Panel panelDiscord;
        private System.Windows.Forms.Panel panelTeamspeak;
        private System.Windows.Forms.Panel panelSkype;
        private System.Windows.Forms.Label lbSkype;
        private System.Windows.Forms.Label lbSkypeStatus;
        private System.Windows.Forms.Label lbDownUsage;
        private System.Windows.Forms.Label lbDown;
        private System.Windows.Forms.Label lbUPUsage;
        private System.Windows.Forms.Label lbUp;
    }
}


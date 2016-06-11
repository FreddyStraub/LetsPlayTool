namespace LetsPlayTool
{
    partial class frmEinstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEinstellungen));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.lbEinstellungen = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Showanimation = new System.Windows.Forms.Timer(this.components);
            this.Closeanimation = new System.Windows.Forms.Timer(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.bMarker = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bProgramme = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bÜberwachung = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bAllgemeines = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bTimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.lbEinstellungen);
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.animator1.SetDecoration(this.HeaderBar, BunifuAnimatorNS.DecorationType.None);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(897, 59);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // lbEinstellungen
            // 
            this.lbEinstellungen.AutoSize = true;
            this.animator1.SetDecoration(this.lbEinstellungen, BunifuAnimatorNS.DecorationType.None);
            this.lbEinstellungen.Font = new System.Drawing.Font("Windows Command Prompt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEinstellungen.ForeColor = System.Drawing.Color.White;
            this.lbEinstellungen.Location = new System.Drawing.Point(12, 17);
            this.lbEinstellungen.Name = "lbEinstellungen";
            this.lbEinstellungen.Size = new System.Drawing.Size(172, 24);
            this.lbEinstellungen.TabIndex = 2;
            this.lbEinstellungen.Text = "Einstellungen";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.animator1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(850, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Showanimation
            // 
            this.Showanimation.Interval = 10;
            this.Showanimation.Tick += new System.EventHandler(this.Showanimation_Tick);
            // 
            // Closeanimation
            // 
            this.Closeanimation.Interval = 10;
            this.Closeanimation.Tick += new System.EventHandler(this.Closeanimation_Tick);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.panelTabs);
            this.bunifuCards1.Controls.Add(this.panel1);
            this.animator1.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 59);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(897, 553);
            this.bunifuCards1.TabIndex = 2;
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTabs.Controls.Add(this.bMarker);
            this.panelTabs.Controls.Add(this.bProgramme);
            this.panelTabs.Controls.Add(this.bÜberwachung);
            this.panelTabs.Controls.Add(this.bAllgemeines);
            this.panelTabs.Controls.Add(this.bTimer);
            this.animator1.SetDecoration(this.panelTabs, BunifuAnimatorNS.DecorationType.None);
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(202, 553);
            this.panelTabs.TabIndex = 1;
            // 
            // bMarker
            // 
            this.bMarker.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bMarker.BackColor = System.Drawing.Color.DodgerBlue;
            this.bMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMarker.BorderRadius = 0;
            this.bMarker.ButtonText = "    Marker";
            this.bMarker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bMarker, BunifuAnimatorNS.DecorationType.None);
            this.bMarker.Iconcolor = System.Drawing.Color.Transparent;
            this.bMarker.Iconimage = null;
            this.bMarker.Iconimage_right = null;
            this.bMarker.Iconimage_right_Selected = null;
            this.bMarker.Iconimage_Selected = null;
            this.bMarker.IsTab = true;
            this.bMarker.Location = new System.Drawing.Point(1, 159);
            this.bMarker.Name = "bMarker";
            this.bMarker.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bMarker.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bMarker.OnHoverTextColor = System.Drawing.Color.White;
            this.bMarker.selected = false;
            this.bMarker.Size = new System.Drawing.Size(201, 48);
            this.bMarker.TabIndex = 5;
            this.bMarker.Textcolor = System.Drawing.Color.White;
            this.bMarker.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMarker.Click += new System.EventHandler(this.bMarker_Click_1);
            // 
            // bProgramme
            // 
            this.bProgramme.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bProgramme.BackColor = System.Drawing.Color.DodgerBlue;
            this.bProgramme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProgramme.BorderRadius = 0;
            this.bProgramme.ButtonText = "    Programme";
            this.bProgramme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bProgramme, BunifuAnimatorNS.DecorationType.None);
            this.bProgramme.Iconcolor = System.Drawing.Color.Transparent;
            this.bProgramme.Iconimage = null;
            this.bProgramme.Iconimage_right = null;
            this.bProgramme.Iconimage_right_Selected = null;
            this.bProgramme.Iconimage_Selected = null;
            this.bProgramme.IsTab = true;
            this.bProgramme.Location = new System.Drawing.Point(1, 65);
            this.bProgramme.Name = "bProgramme";
            this.bProgramme.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bProgramme.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bProgramme.OnHoverTextColor = System.Drawing.Color.White;
            this.bProgramme.selected = false;
            this.bProgramme.Size = new System.Drawing.Size(201, 48);
            this.bProgramme.TabIndex = 4;
            this.bProgramme.Textcolor = System.Drawing.Color.White;
            this.bProgramme.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProgramme.Click += new System.EventHandler(this.bProgramme_Click);
            // 
            // bÜberwachung
            // 
            this.bÜberwachung.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bÜberwachung.BackColor = System.Drawing.Color.DodgerBlue;
            this.bÜberwachung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bÜberwachung.BorderRadius = 0;
            this.bÜberwachung.ButtonText = "    Überwachung";
            this.bÜberwachung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bÜberwachung, BunifuAnimatorNS.DecorationType.None);
            this.bÜberwachung.Iconcolor = System.Drawing.Color.Transparent;
            this.bÜberwachung.Iconimage = null;
            this.bÜberwachung.Iconimage_right = null;
            this.bÜberwachung.Iconimage_right_Selected = null;
            this.bÜberwachung.Iconimage_Selected = null;
            this.bÜberwachung.IsTab = true;
            this.bÜberwachung.Location = new System.Drawing.Point(1, 206);
            this.bÜberwachung.Name = "bÜberwachung";
            this.bÜberwachung.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bÜberwachung.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bÜberwachung.OnHoverTextColor = System.Drawing.Color.White;
            this.bÜberwachung.selected = false;
            this.bÜberwachung.Size = new System.Drawing.Size(201, 48);
            this.bÜberwachung.TabIndex = 3;
            this.bÜberwachung.Textcolor = System.Drawing.Color.White;
            this.bÜberwachung.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bÜberwachung.Click += new System.EventHandler(this.bÜberwachung_Click);
            // 
            // bAllgemeines
            // 
            this.bAllgemeines.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAllgemeines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAllgemeines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAllgemeines.BorderRadius = 0;
            this.bAllgemeines.ButtonText = "    Allgemeines";
            this.bAllgemeines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bAllgemeines, BunifuAnimatorNS.DecorationType.None);
            this.bAllgemeines.Iconcolor = System.Drawing.Color.Transparent;
            this.bAllgemeines.Iconimage = null;
            this.bAllgemeines.Iconimage_right = null;
            this.bAllgemeines.Iconimage_right_Selected = null;
            this.bAllgemeines.Iconimage_Selected = null;
            this.bAllgemeines.IsTab = true;
            this.bAllgemeines.Location = new System.Drawing.Point(1, 18);
            this.bAllgemeines.Name = "bAllgemeines";
            this.bAllgemeines.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAllgemeines.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAllgemeines.OnHoverTextColor = System.Drawing.Color.White;
            this.bAllgemeines.selected = true;
            this.bAllgemeines.Size = new System.Drawing.Size(201, 48);
            this.bAllgemeines.TabIndex = 2;
            this.bAllgemeines.Textcolor = System.Drawing.Color.White;
            this.bAllgemeines.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAllgemeines.Click += new System.EventHandler(this.bMarker_Click);
            // 
            // bTimer
            // 
            this.bTimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.bTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTimer.BorderRadius = 0;
            this.bTimer.ButtonText = "    Timer";
            this.bTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.bTimer, BunifuAnimatorNS.DecorationType.None);
            this.bTimer.Iconcolor = System.Drawing.Color.Transparent;
            this.bTimer.Iconimage = null;
            this.bTimer.Iconimage_right = null;
            this.bTimer.Iconimage_right_Selected = null;
            this.bTimer.Iconimage_Selected = null;
            this.bTimer.IsTab = true;
            this.bTimer.Location = new System.Drawing.Point(1, 112);
            this.bTimer.Name = "bTimer";
            this.bTimer.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bTimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTimer.OnHoverTextColor = System.Drawing.Color.White;
            this.bTimer.selected = false;
            this.bTimer.Size = new System.Drawing.Size(201, 48);
            this.bTimer.TabIndex = 0;
            this.bTimer.Textcolor = System.Drawing.Color.White;
            this.bTimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTimer.Click += new System.EventHandler(this.bTimer_Click);
            // 
            // panel1
            // 
            this.animator1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(202, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 553);
            this.panel1.TabIndex = 2;
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlAdded);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animator1.Cursor = null;
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
            this.animator1.DefaultAnimation = animation1;
            this.animator1.Interval = 5;
            this.animator1.MaxAnimationTime = 3000;
            // 
            // frmEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(897, 615);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.HeaderBar);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(897, 615);
            this.MinimumSize = new System.Drawing.Size(897, 615);
            this.Name = "frmEinstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEinstellungen";
            this.Load += new System.EventHandler(this.frmEinstellungen_Load);
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.panelTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Timer Showanimation;
        private System.Windows.Forms.Timer Closeanimation;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Panel panelTabs;
        private Bunifu.Framework.UI.BunifuFlatButton bTimer;
        private System.Windows.Forms.Label lbEinstellungen;
        private Bunifu.Framework.UI.BunifuFlatButton bAllgemeines;
        private Bunifu.Framework.UI.BunifuFlatButton bÜberwachung;
        private Bunifu.Framework.UI.BunifuFlatButton bProgramme;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bMarker;
        private BunifuAnimatorNS.Animator animator1;
    }
}
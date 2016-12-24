﻿namespace LetsPlayTool
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
            this.bTutorials = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bMessenger = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bAbbrechen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bSpeichern = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bMarker = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bProgramme = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bÜberwachung = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bAllgemeines = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bTimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
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
            this.panelAnimator.SetDecoration(this.HeaderBar, BunifuAnimatorNS.DecorationType.None);
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
            this.panelAnimator.SetDecoration(this.lbEinstellungen, BunifuAnimatorNS.DecorationType.None);
            this.lbEinstellungen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEinstellungen.ForeColor = System.Drawing.Color.White;
            this.lbEinstellungen.Location = new System.Drawing.Point(8, 11);
            this.lbEinstellungen.Name = "lbEinstellungen";
            this.lbEinstellungen.Size = new System.Drawing.Size(176, 37);
            this.lbEinstellungen.TabIndex = 2;
            this.lbEinstellungen.Text = "Einstellungen";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
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
            this.panelAnimator.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
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
            this.panelTabs.Controls.Add(this.bTutorials);
            this.panelTabs.Controls.Add(this.bMessenger);
            this.panelTabs.Controls.Add(this.bInfo);
            this.panelTabs.Controls.Add(this.bAbbrechen);
            this.panelTabs.Controls.Add(this.bSpeichern);
            this.panelTabs.Controls.Add(this.bMarker);
            this.panelTabs.Controls.Add(this.bProgramme);
            this.panelTabs.Controls.Add(this.bÜberwachung);
            this.panelTabs.Controls.Add(this.bAllgemeines);
            this.panelTabs.Controls.Add(this.bTimer);
            this.panelAnimator.SetDecoration(this.panelTabs, BunifuAnimatorNS.DecorationType.None);
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(202, 553);
            this.panelTabs.TabIndex = 1;
            // 
            // bTutorials
            // 
            this.bTutorials.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTutorials.BackColor = System.Drawing.Color.DodgerBlue;
            this.bTutorials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bTutorials.BorderRadius = 0;
            this.bTutorials.ButtonText = "    Tutorials";
            this.bTutorials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bTutorials, BunifuAnimatorNS.DecorationType.None);
            this.bTutorials.DisabledColor = System.Drawing.Color.Gray;
            this.bTutorials.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTutorials.Iconcolor = System.Drawing.Color.Transparent;
            this.bTutorials.Iconimage = null;
            this.bTutorials.Iconimage_right = null;
            this.bTutorials.Iconimage_right_Selected = null;
            this.bTutorials.Iconimage_Selected = null;
            this.bTutorials.IconMarginLeft = 0;
            this.bTutorials.IconMarginRight = 0;
            this.bTutorials.IconRightVisible = true;
            this.bTutorials.IconRightZoom = 0D;
            this.bTutorials.IconVisible = true;
            this.bTutorials.IconZoom = 90D;
            this.bTutorials.IsTab = true;
            this.bTutorials.Location = new System.Drawing.Point(1, 330);
            this.bTutorials.Name = "bTutorials";
            this.bTutorials.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bTutorials.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTutorials.OnHoverTextColor = System.Drawing.Color.White;
            this.bTutorials.selected = false;
            this.bTutorials.Size = new System.Drawing.Size(201, 48);
            this.bTutorials.TabIndex = 10;
            this.bTutorials.Text = "    Tutorials";
            this.bTutorials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTutorials.Textcolor = System.Drawing.Color.White;
            this.bTutorials.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTutorials.Click += new System.EventHandler(this.bTutorials_Click);
            // 
            // bMessenger
            // 
            this.bMessenger.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bMessenger.BackColor = System.Drawing.Color.DodgerBlue;
            this.bMessenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMessenger.BorderRadius = 0;
            this.bMessenger.ButtonText = "    Messenger";
            this.bMessenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bMessenger, BunifuAnimatorNS.DecorationType.None);
            this.bMessenger.DisabledColor = System.Drawing.Color.Gray;
            this.bMessenger.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMessenger.Iconcolor = System.Drawing.Color.Transparent;
            this.bMessenger.Iconimage = null;
            this.bMessenger.Iconimage_right = null;
            this.bMessenger.Iconimage_right_Selected = null;
            this.bMessenger.Iconimage_Selected = null;
            this.bMessenger.IconMarginLeft = 0;
            this.bMessenger.IconMarginRight = 0;
            this.bMessenger.IconRightVisible = true;
            this.bMessenger.IconRightZoom = 0D;
            this.bMessenger.IconVisible = true;
            this.bMessenger.IconZoom = 90D;
            this.bMessenger.IsTab = true;
            this.bMessenger.Location = new System.Drawing.Point(1, 252);
            this.bMessenger.Name = "bMessenger";
            this.bMessenger.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bMessenger.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bMessenger.OnHoverTextColor = System.Drawing.Color.White;
            this.bMessenger.selected = false;
            this.bMessenger.Size = new System.Drawing.Size(201, 48);
            this.bMessenger.TabIndex = 9;
            this.bMessenger.Text = "    Messenger";
            this.bMessenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMessenger.Textcolor = System.Drawing.Color.White;
            this.bMessenger.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMessenger.Click += new System.EventHandler(this.bMessenger_Click);
            // 
            // bInfo
            // 
            this.bInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.bInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bInfo.BorderRadius = 0;
            this.bInfo.ButtonText = "    Info";
            this.bInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bInfo, BunifuAnimatorNS.DecorationType.None);
            this.bInfo.DisabledColor = System.Drawing.Color.Gray;
            this.bInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.bInfo.Iconimage = null;
            this.bInfo.Iconimage_right = null;
            this.bInfo.Iconimage_right_Selected = null;
            this.bInfo.Iconimage_Selected = null;
            this.bInfo.IconMarginLeft = 0;
            this.bInfo.IconMarginRight = 0;
            this.bInfo.IconRightVisible = true;
            this.bInfo.IconRightZoom = 0D;
            this.bInfo.IconVisible = true;
            this.bInfo.IconZoom = 90D;
            this.bInfo.IsTab = true;
            this.bInfo.Location = new System.Drawing.Point(1, 377);
            this.bInfo.Name = "bInfo";
            this.bInfo.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.bInfo.selected = false;
            this.bInfo.Size = new System.Drawing.Size(201, 48);
            this.bInfo.TabIndex = 8;
            this.bInfo.Text = "    Info";
            this.bInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bInfo.Textcolor = System.Drawing.Color.White;
            this.bInfo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInfo.Click += new System.EventHandler(this.bInfo_Click);
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAbbrechen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAbbrechen.BorderRadius = 0;
            this.bAbbrechen.ButtonText = "   Abbrechen";
            this.bAbbrechen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bAbbrechen, BunifuAnimatorNS.DecorationType.None);
            this.bAbbrechen.DisabledColor = System.Drawing.Color.Gray;
            this.bAbbrechen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAbbrechen.Iconcolor = System.Drawing.Color.Transparent;
            this.bAbbrechen.Iconimage = null;
            this.bAbbrechen.Iconimage_right = null;
            this.bAbbrechen.Iconimage_right_Selected = null;
            this.bAbbrechen.Iconimage_Selected = null;
            this.bAbbrechen.IconMarginLeft = 0;
            this.bAbbrechen.IconMarginRight = 0;
            this.bAbbrechen.IconRightVisible = true;
            this.bAbbrechen.IconRightZoom = 0D;
            this.bAbbrechen.IconVisible = true;
            this.bAbbrechen.IconZoom = 90D;
            this.bAbbrechen.IsTab = false;
            this.bAbbrechen.Location = new System.Drawing.Point(102, 502);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAbbrechen.OnHoverTextColor = System.Drawing.Color.White;
            this.bAbbrechen.selected = false;
            this.bAbbrechen.Size = new System.Drawing.Size(100, 48);
            this.bAbbrechen.TabIndex = 7;
            this.bAbbrechen.Text = "   Abbrechen";
            this.bAbbrechen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAbbrechen.Textcolor = System.Drawing.Color.White;
            this.bAbbrechen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAbbrechen.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bSpeichern
            // 
            this.bSpeichern.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bSpeichern.BackColor = System.Drawing.Color.DodgerBlue;
            this.bSpeichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSpeichern.BorderRadius = 0;
            this.bSpeichern.ButtonText = "    Speichern";
            this.bSpeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bSpeichern, BunifuAnimatorNS.DecorationType.None);
            this.bSpeichern.DisabledColor = System.Drawing.Color.Gray;
            this.bSpeichern.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpeichern.Iconcolor = System.Drawing.Color.Transparent;
            this.bSpeichern.Iconimage = null;
            this.bSpeichern.Iconimage_right = null;
            this.bSpeichern.Iconimage_right_Selected = null;
            this.bSpeichern.Iconimage_Selected = null;
            this.bSpeichern.IconMarginLeft = 0;
            this.bSpeichern.IconMarginRight = 0;
            this.bSpeichern.IconRightVisible = true;
            this.bSpeichern.IconRightZoom = 0D;
            this.bSpeichern.IconVisible = true;
            this.bSpeichern.IconZoom = 90D;
            this.bSpeichern.IsTab = false;
            this.bSpeichern.Location = new System.Drawing.Point(1, 502);
            this.bSpeichern.Name = "bSpeichern";
            this.bSpeichern.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bSpeichern.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bSpeichern.OnHoverTextColor = System.Drawing.Color.White;
            this.bSpeichern.selected = false;
            this.bSpeichern.Size = new System.Drawing.Size(100, 48);
            this.bSpeichern.TabIndex = 6;
            this.bSpeichern.Text = "    Speichern";
            this.bSpeichern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSpeichern.Textcolor = System.Drawing.Color.White;
            this.bSpeichern.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpeichern.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bMarker
            // 
            this.bMarker.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bMarker.BackColor = System.Drawing.Color.DodgerBlue;
            this.bMarker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bMarker.BorderRadius = 0;
            this.bMarker.ButtonText = "    Marker";
            this.bMarker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bMarker, BunifuAnimatorNS.DecorationType.None);
            this.bMarker.DisabledColor = System.Drawing.Color.Gray;
            this.bMarker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMarker.Iconcolor = System.Drawing.Color.Transparent;
            this.bMarker.Iconimage = null;
            this.bMarker.Iconimage_right = null;
            this.bMarker.Iconimage_right_Selected = null;
            this.bMarker.Iconimage_Selected = null;
            this.bMarker.IconMarginLeft = 0;
            this.bMarker.IconMarginRight = 0;
            this.bMarker.IconRightVisible = true;
            this.bMarker.IconRightZoom = 0D;
            this.bMarker.IconVisible = true;
            this.bMarker.IconZoom = 90D;
            this.bMarker.IsTab = true;
            this.bMarker.Location = new System.Drawing.Point(1, 159);
            this.bMarker.Name = "bMarker";
            this.bMarker.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bMarker.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bMarker.OnHoverTextColor = System.Drawing.Color.White;
            this.bMarker.selected = false;
            this.bMarker.Size = new System.Drawing.Size(201, 48);
            this.bMarker.TabIndex = 5;
            this.bMarker.Text = "    Marker";
            this.bMarker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelAnimator.SetDecoration(this.bProgramme, BunifuAnimatorNS.DecorationType.None);
            this.bProgramme.DisabledColor = System.Drawing.Color.Gray;
            this.bProgramme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProgramme.Iconcolor = System.Drawing.Color.Transparent;
            this.bProgramme.Iconimage = null;
            this.bProgramme.Iconimage_right = null;
            this.bProgramme.Iconimage_right_Selected = null;
            this.bProgramme.Iconimage_Selected = null;
            this.bProgramme.IconMarginLeft = 0;
            this.bProgramme.IconMarginRight = 0;
            this.bProgramme.IconRightVisible = true;
            this.bProgramme.IconRightZoom = 0D;
            this.bProgramme.IconVisible = true;
            this.bProgramme.IconZoom = 90D;
            this.bProgramme.IsTab = true;
            this.bProgramme.Location = new System.Drawing.Point(1, 65);
            this.bProgramme.Name = "bProgramme";
            this.bProgramme.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bProgramme.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bProgramme.OnHoverTextColor = System.Drawing.Color.White;
            this.bProgramme.selected = false;
            this.bProgramme.Size = new System.Drawing.Size(201, 48);
            this.bProgramme.TabIndex = 4;
            this.bProgramme.Text = "    Programme";
            this.bProgramme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelAnimator.SetDecoration(this.bÜberwachung, BunifuAnimatorNS.DecorationType.None);
            this.bÜberwachung.DisabledColor = System.Drawing.Color.Gray;
            this.bÜberwachung.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bÜberwachung.Iconcolor = System.Drawing.Color.Transparent;
            this.bÜberwachung.Iconimage = null;
            this.bÜberwachung.Iconimage_right = null;
            this.bÜberwachung.Iconimage_right_Selected = null;
            this.bÜberwachung.Iconimage_Selected = null;
            this.bÜberwachung.IconMarginLeft = 0;
            this.bÜberwachung.IconMarginRight = 0;
            this.bÜberwachung.IconRightVisible = true;
            this.bÜberwachung.IconRightZoom = 0D;
            this.bÜberwachung.IconVisible = true;
            this.bÜberwachung.IconZoom = 90D;
            this.bÜberwachung.IsTab = true;
            this.bÜberwachung.Location = new System.Drawing.Point(1, 206);
            this.bÜberwachung.Name = "bÜberwachung";
            this.bÜberwachung.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bÜberwachung.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bÜberwachung.OnHoverTextColor = System.Drawing.Color.White;
            this.bÜberwachung.selected = false;
            this.bÜberwachung.Size = new System.Drawing.Size(201, 48);
            this.bÜberwachung.TabIndex = 3;
            this.bÜberwachung.Text = "    Überwachung";
            this.bÜberwachung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bÜberwachung.Textcolor = System.Drawing.Color.White;
            this.bÜberwachung.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bÜberwachung.Click += new System.EventHandler(this.bÜberwachung_Click);
            // 
            // bAllgemeines
            // 
            this.bAllgemeines.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAllgemeines.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAllgemeines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAllgemeines.BorderRadius = 0;
            this.bAllgemeines.ButtonText = "    Allgemeines";
            this.bAllgemeines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.bAllgemeines, BunifuAnimatorNS.DecorationType.None);
            this.bAllgemeines.DisabledColor = System.Drawing.Color.Gray;
            this.bAllgemeines.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAllgemeines.Iconcolor = System.Drawing.Color.Transparent;
            this.bAllgemeines.Iconimage = null;
            this.bAllgemeines.Iconimage_right = null;
            this.bAllgemeines.Iconimage_right_Selected = null;
            this.bAllgemeines.Iconimage_Selected = null;
            this.bAllgemeines.IconMarginLeft = 0;
            this.bAllgemeines.IconMarginRight = 0;
            this.bAllgemeines.IconRightVisible = true;
            this.bAllgemeines.IconRightZoom = 0D;
            this.bAllgemeines.IconVisible = true;
            this.bAllgemeines.IconZoom = 90D;
            this.bAllgemeines.IsTab = true;
            this.bAllgemeines.Location = new System.Drawing.Point(1, 18);
            this.bAllgemeines.Name = "bAllgemeines";
            this.bAllgemeines.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAllgemeines.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAllgemeines.OnHoverTextColor = System.Drawing.Color.White;
            this.bAllgemeines.selected = true;
            this.bAllgemeines.Size = new System.Drawing.Size(201, 48);
            this.bAllgemeines.TabIndex = 2;
            this.bAllgemeines.Text = "    Allgemeines";
            this.bAllgemeines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelAnimator.SetDecoration(this.bTimer, BunifuAnimatorNS.DecorationType.None);
            this.bTimer.DisabledColor = System.Drawing.Color.Gray;
            this.bTimer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTimer.Iconcolor = System.Drawing.Color.Transparent;
            this.bTimer.Iconimage = null;
            this.bTimer.Iconimage_right = null;
            this.bTimer.Iconimage_right_Selected = null;
            this.bTimer.Iconimage_Selected = null;
            this.bTimer.IconMarginLeft = 0;
            this.bTimer.IconMarginRight = 0;
            this.bTimer.IconRightVisible = true;
            this.bTimer.IconRightZoom = 0D;
            this.bTimer.IconVisible = true;
            this.bTimer.IconZoom = 90D;
            this.bTimer.IsTab = true;
            this.bTimer.Location = new System.Drawing.Point(1, 112);
            this.bTimer.Name = "bTimer";
            this.bTimer.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bTimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTimer.OnHoverTextColor = System.Drawing.Color.White;
            this.bTimer.selected = false;
            this.bTimer.Size = new System.Drawing.Size(201, 48);
            this.bTimer.TabIndex = 0;
            this.bTimer.Text = "    Timer";
            this.bTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTimer.Textcolor = System.Drawing.Color.White;
            this.bTimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTimer.Click += new System.EventHandler(this.bTimer_Click);
            // 
            // panel1
            // 
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(202, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 553);
            this.panel1.TabIndex = 2;
            this.panel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlAdded);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
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
            this.panelAnimator.Interval = 5;
            this.panelAnimator.MaxAnimationTime = 3000;
            // 
            // frmEinstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(897, 615);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.HeaderBar);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private Bunifu.Framework.UI.BunifuFlatButton bAbbrechen;
        private Bunifu.Framework.UI.BunifuFlatButton bSpeichern;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private Bunifu.Framework.UI.BunifuFlatButton bInfo;
        private Bunifu.Framework.UI.BunifuFlatButton bMessenger;
        private Bunifu.Framework.UI.BunifuFlatButton bTutorials;
    }
}
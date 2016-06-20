namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class TimerTab
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "00:00:01:00"}, -1, System.Drawing.Color.White, System.Drawing.Color.Red, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerTab));
            this.lvTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bZeitEntfernen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bZeitHinzufügen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bProfilLöschen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bProfilErstellen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbProfiles = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bFarbe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bFertig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.switchBlinken = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.nudTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudTimeMSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudTimeHours = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHours)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTimes
            // 
            this.lvTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lvTimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTimes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvTimes.Location = new System.Drawing.Point(291, 19);
            this.lvTimes.Name = "lvTimes";
            this.lvTimes.Size = new System.Drawing.Size(174, 320);
            this.lvTimes.TabIndex = 0;
            this.lvTimes.UseCompatibleStateImageBehavior = false;
            this.lvTimes.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zeitmarker";
            this.columnHeader1.Width = 250;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bZeitEntfernen);
            this.groupBox2.Controls.Add(this.bZeitHinzufügen);
            this.groupBox2.Controls.Add(this.bProfilLöschen);
            this.groupBox2.Controls.Add(this.bProfilErstellen);
            this.groupBox2.Controls.Add(this.lbProfiles);
            this.groupBox2.Controls.Add(this.lvTimes);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 344);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // bZeitEntfernen
            // 
            this.bZeitEntfernen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bZeitEntfernen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bZeitEntfernen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bZeitEntfernen.BorderRadius = 0;
            this.bZeitEntfernen.ButtonText = "     Zeit entfernen";
            this.bZeitEntfernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bZeitEntfernen.Iconcolor = System.Drawing.Color.Transparent;
            this.bZeitEntfernen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bZeitEntfernen.Iconimage")));
            this.bZeitEntfernen.Iconimage_right = null;
            this.bZeitEntfernen.Iconimage_right_Selected = null;
            this.bZeitEntfernen.Iconimage_Selected = null;
            this.bZeitEntfernen.IsTab = false;
            this.bZeitEntfernen.Location = new System.Drawing.Point(470, 216);
            this.bZeitEntfernen.Name = "bZeitEntfernen";
            this.bZeitEntfernen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bZeitEntfernen.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bZeitEntfernen.OnHoverTextColor = System.Drawing.Color.White;
            this.bZeitEntfernen.selected = false;
            this.bZeitEntfernen.Size = new System.Drawing.Size(194, 48);
            this.bZeitEntfernen.TabIndex = 9;
            this.bZeitEntfernen.Textcolor = System.Drawing.Color.White;
            this.bZeitEntfernen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bZeitHinzufügen
            // 
            this.bZeitHinzufügen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bZeitHinzufügen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bZeitHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bZeitHinzufügen.BorderRadius = 0;
            this.bZeitHinzufügen.ButtonText = "     Zeit hinzufügen";
            this.bZeitHinzufügen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bZeitHinzufügen.Iconcolor = System.Drawing.Color.Transparent;
            this.bZeitHinzufügen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bZeitHinzufügen.Iconimage")));
            this.bZeitHinzufügen.Iconimage_right = null;
            this.bZeitHinzufügen.Iconimage_right_Selected = null;
            this.bZeitHinzufügen.Iconimage_Selected = null;
            this.bZeitHinzufügen.IsTab = false;
            this.bZeitHinzufügen.Location = new System.Drawing.Point(470, 162);
            this.bZeitHinzufügen.Name = "bZeitHinzufügen";
            this.bZeitHinzufügen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bZeitHinzufügen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bZeitHinzufügen.OnHoverTextColor = System.Drawing.Color.White;
            this.bZeitHinzufügen.selected = false;
            this.bZeitHinzufügen.Size = new System.Drawing.Size(194, 48);
            this.bZeitHinzufügen.TabIndex = 8;
            this.bZeitHinzufügen.Textcolor = System.Drawing.Color.White;
            this.bZeitHinzufügen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZeitHinzufügen.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bProfilLöschen
            // 
            this.bProfilLöschen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bProfilLöschen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bProfilLöschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProfilLöschen.BorderRadius = 0;
            this.bProfilLöschen.ButtonText = "     Profil löschen";
            this.bProfilLöschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProfilLöschen.Iconcolor = System.Drawing.Color.Transparent;
            this.bProfilLöschen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bProfilLöschen.Iconimage")));
            this.bProfilLöschen.Iconimage_right = null;
            this.bProfilLöschen.Iconimage_right_Selected = null;
            this.bProfilLöschen.Iconimage_Selected = null;
            this.bProfilLöschen.IsTab = false;
            this.bProfilLöschen.Location = new System.Drawing.Point(471, 73);
            this.bProfilLöschen.Name = "bProfilLöschen";
            this.bProfilLöschen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bProfilLöschen.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bProfilLöschen.OnHoverTextColor = System.Drawing.Color.White;
            this.bProfilLöschen.selected = false;
            this.bProfilLöschen.Size = new System.Drawing.Size(194, 48);
            this.bProfilLöschen.TabIndex = 7;
            this.bProfilLöschen.Textcolor = System.Drawing.Color.White;
            this.bProfilLöschen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bProfilErstellen
            // 
            this.bProfilErstellen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bProfilErstellen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bProfilErstellen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProfilErstellen.BorderRadius = 0;
            this.bProfilErstellen.ButtonText = "     Profil erstellen";
            this.bProfilErstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProfilErstellen.Iconcolor = System.Drawing.Color.Transparent;
            this.bProfilErstellen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bProfilErstellen.Iconimage")));
            this.bProfilErstellen.Iconimage_right = null;
            this.bProfilErstellen.Iconimage_right_Selected = null;
            this.bProfilErstellen.Iconimage_Selected = null;
            this.bProfilErstellen.IsTab = false;
            this.bProfilErstellen.Location = new System.Drawing.Point(471, 19);
            this.bProfilErstellen.Name = "bProfilErstellen";
            this.bProfilErstellen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bProfilErstellen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bProfilErstellen.OnHoverTextColor = System.Drawing.Color.White;
            this.bProfilErstellen.selected = false;
            this.bProfilErstellen.Size = new System.Drawing.Size(194, 48);
            this.bProfilErstellen.TabIndex = 6;
            this.bProfilErstellen.Textcolor = System.Drawing.Color.White;
            this.bProfilErstellen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbProfiles
            // 
            this.lbProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lbProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfiles.ForeColor = System.Drawing.Color.White;
            this.lbProfiles.FormattingEnabled = true;
            this.lbProfiles.ItemHeight = 20;
            this.lbProfiles.Items.AddRange(new object[] {
            "Minecraft",
            "Overwatch",
            "Tutorial"});
            this.lbProfiles.Location = new System.Drawing.Point(6, 19);
            this.lbProfiles.Name = "lbProfiles";
            this.lbProfiles.Size = new System.Drawing.Size(279, 320);
            this.lbProfiles.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bFarbe);
            this.groupBox3.Controls.Add(this.bFertig);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.switchBlinken);
            this.groupBox3.Controls.Add(this.nudTimeSeconds);
            this.groupBox3.Controls.Add(this.nudTimeMinutes);
            this.groupBox3.Controls.Add(this.nudTimeMSeconds);
            this.groupBox3.Controls.Add(this.nudTimeHours);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 180);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zeit hinzufügen";
            this.groupBox3.Visible = false;
            // 
            // bFarbe
            // 
            this.bFarbe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFarbe.BorderRadius = 0;
            this.bFarbe.ButtonText = "     Farbe";
            this.bFarbe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFarbe.Iconcolor = System.Drawing.Color.Transparent;
            this.bFarbe.Iconimage = null;
            this.bFarbe.Iconimage_right = null;
            this.bFarbe.Iconimage_right_Selected = null;
            this.bFarbe.Iconimage_Selected = null;
            this.bFarbe.IsTab = false;
            this.bFarbe.Location = new System.Drawing.Point(17, 86);
            this.bFarbe.Name = "bFarbe";
            this.bFarbe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bFarbe.OnHoverTextColor = System.Drawing.Color.White;
            this.bFarbe.Padding = new System.Windows.Forms.Padding(129, 0, 0, 0);
            this.bFarbe.selected = false;
            this.bFarbe.Size = new System.Drawing.Size(330, 31);
            this.bFarbe.TabIndex = 11;
            this.bFarbe.Textcolor = System.Drawing.Color.White;
            this.bFarbe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bFertig
            // 
            this.bFertig.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bFertig.BackColor = System.Drawing.Color.DodgerBlue;
            this.bFertig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFertig.BorderRadius = 0;
            this.bFertig.ButtonText = "     Fertig";
            this.bFertig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFertig.Iconcolor = System.Drawing.Color.Transparent;
            this.bFertig.Iconimage = ((System.Drawing.Image)(resources.GetObject("bFertig.Iconimage")));
            this.bFertig.Iconimage_right = null;
            this.bFertig.Iconimage_right_Selected = null;
            this.bFertig.Iconimage_Selected = null;
            this.bFertig.IsTab = false;
            this.bFertig.Location = new System.Drawing.Point(524, 136);
            this.bFertig.Name = "bFertig";
            this.bFertig.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bFertig.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bFertig.OnHoverTextColor = System.Drawing.Color.White;
            this.bFertig.selected = false;
            this.bFertig.Size = new System.Drawing.Size(140, 38);
            this.bFertig.TabIndex = 10;
            this.bFertig.Textcolor = System.Drawing.Color.White;
            this.bFertig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blinken";
            // 
            // switchBlinken
            // 
            this.switchBlinken.BackColor = System.Drawing.Color.Transparent;
            this.switchBlinken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchBlinken.BackgroundImage")));
            this.switchBlinken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchBlinken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchBlinken.Location = new System.Drawing.Point(444, 61);
            this.switchBlinken.Name = "switchBlinken";
            this.switchBlinken.OffColor = System.Drawing.Color.Gray;
            this.switchBlinken.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchBlinken.Size = new System.Drawing.Size(43, 25);
            this.switchBlinken.TabIndex = 7;
            this.switchBlinken.Value = true;
            // 
            // nudTimeSeconds
            // 
            this.nudTimeSeconds.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeSeconds.ForeColor = System.Drawing.Color.White;
            this.nudTimeSeconds.Location = new System.Drawing.Point(185, 36);
            this.nudTimeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeSeconds.Name = "nudTimeSeconds";
            this.nudTimeSeconds.Size = new System.Drawing.Size(78, 31);
            this.nudTimeSeconds.TabIndex = 4;
            // 
            // nudTimeMinutes
            // 
            this.nudTimeMinutes.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeMinutes.ForeColor = System.Drawing.Color.White;
            this.nudTimeMinutes.Location = new System.Drawing.Point(101, 36);
            this.nudTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeMinutes.Name = "nudTimeMinutes";
            this.nudTimeMinutes.Size = new System.Drawing.Size(78, 31);
            this.nudTimeMinutes.TabIndex = 2;
            // 
            // nudTimeMSeconds
            // 
            this.nudTimeMSeconds.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeMSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeMSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeMSeconds.ForeColor = System.Drawing.Color.White;
            this.nudTimeMSeconds.Location = new System.Drawing.Point(269, 36);
            this.nudTimeMSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeMSeconds.Name = "nudTimeMSeconds";
            this.nudTimeMSeconds.Size = new System.Drawing.Size(78, 31);
            this.nudTimeMSeconds.TabIndex = 3;
            // 
            // nudTimeHours
            // 
            this.nudTimeHours.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeHours.ForeColor = System.Drawing.Color.White;
            this.nudTimeHours.Location = new System.Drawing.Point(17, 36);
            this.nudTimeHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeHours.Name = "nudTimeHours";
            this.nudTimeHours.Size = new System.Drawing.Size(78, 31);
            this.nudTimeHours.TabIndex = 1;
            // 
            // TimerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerTab";
            this.Text = "TimerTab";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudTimeSeconds;
        private System.Windows.Forms.NumericUpDown nudTimeMinutes;
        private System.Windows.Forms.NumericUpDown nudTimeMSeconds;
        private System.Windows.Forms.NumericUpDown nudTimeHours;
        private System.Windows.Forms.ListBox lbProfiles;
        private Bunifu.Framework.UI.BunifuFlatButton bProfilErstellen;
        private Bunifu.Framework.UI.BunifuFlatButton bProfilLöschen;
        private Bunifu.Framework.UI.BunifuFlatButton bZeitEntfernen;
        private Bunifu.Framework.UI.BunifuFlatButton bZeitHinzufügen;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchBlinken;
        private Bunifu.Framework.UI.BunifuFlatButton bFertig;
        private Bunifu.Framework.UI.BunifuFlatButton bFarbe;
    }
}
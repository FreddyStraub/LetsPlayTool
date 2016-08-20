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
            this.gbText = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.gbText.SuspendLayout();
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
            this.lvTimes.SelectedIndexChanged += new System.EventHandler(this.lvTimes_SelectedIndexChanged);
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
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bZeitEntfernen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZeitEntfernen.Iconcolor = System.Drawing.Color.Transparent;
            this.bZeitEntfernen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bZeitEntfernen.Iconimage")));
            this.bZeitEntfernen.Iconimage_right = null;
            this.bZeitEntfernen.Iconimage_right_Selected = null;
            this.bZeitEntfernen.Iconimage_Selected = null;
            this.bZeitEntfernen.IconZoom = 90D;
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
            this.bZeitEntfernen.Click += new System.EventHandler(this.bZeitEntfernen_Click);
            // 
            // bZeitHinzufügen
            // 
            this.bZeitHinzufügen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bZeitHinzufügen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bZeitHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bZeitHinzufügen.BorderRadius = 0;
            this.bZeitHinzufügen.ButtonText = "     Zeit hinzufügen";
            this.bZeitHinzufügen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bZeitHinzufügen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZeitHinzufügen.Iconcolor = System.Drawing.Color.Transparent;
            this.bZeitHinzufügen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bZeitHinzufügen.Iconimage")));
            this.bZeitHinzufügen.Iconimage_right = null;
            this.bZeitHinzufügen.Iconimage_right_Selected = null;
            this.bZeitHinzufügen.Iconimage_Selected = null;
            this.bZeitHinzufügen.IconZoom = 90D;
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
            this.bZeitHinzufügen.Click += new System.EventHandler(this.bZeitHinzufügen_Click);
            // 
            // bProfilLöschen
            // 
            this.bProfilLöschen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bProfilLöschen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bProfilLöschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProfilLöschen.BorderRadius = 0;
            this.bProfilLöschen.ButtonText = "     Profil löschen";
            this.bProfilLöschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProfilLöschen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfilLöschen.Iconcolor = System.Drawing.Color.Transparent;
            this.bProfilLöschen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bProfilLöschen.Iconimage")));
            this.bProfilLöschen.Iconimage_right = null;
            this.bProfilLöschen.Iconimage_right_Selected = null;
            this.bProfilLöschen.Iconimage_Selected = null;
            this.bProfilLöschen.IconZoom = 90D;
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
            this.bProfilLöschen.Click += new System.EventHandler(this.bProfilLöschen_Click);
            // 
            // bProfilErstellen
            // 
            this.bProfilErstellen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bProfilErstellen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bProfilErstellen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProfilErstellen.BorderRadius = 0;
            this.bProfilErstellen.ButtonText = "     Profil erstellen";
            this.bProfilErstellen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProfilErstellen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfilErstellen.Iconcolor = System.Drawing.Color.Transparent;
            this.bProfilErstellen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bProfilErstellen.Iconimage")));
            this.bProfilErstellen.Iconimage_right = null;
            this.bProfilErstellen.Iconimage_right_Selected = null;
            this.bProfilErstellen.Iconimage_Selected = null;
            this.bProfilErstellen.IconZoom = 90D;
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
            this.bProfilErstellen.Click += new System.EventHandler(this.bProfilErstellen_Click);
            // 
            // lbProfiles
            // 
            this.lbProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lbProfiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProfiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfiles.ForeColor = System.Drawing.Color.White;
            this.lbProfiles.FormattingEnabled = true;
            this.lbProfiles.ItemHeight = 21;
            this.lbProfiles.Items.AddRange(new object[] {
            "Minecraft",
            "Overwatch",
            "Tutorial"});
            this.lbProfiles.Location = new System.Drawing.Point(6, 19);
            this.lbProfiles.Name = "lbProfiles";
            this.lbProfiles.Size = new System.Drawing.Size(279, 315);
            this.lbProfiles.TabIndex = 5;
            this.lbProfiles.SelectedIndexChanged += new System.EventHandler(this.lbProfiles_SelectedIndexChanged);
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.richTextBox1);
            this.gbText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbText.ForeColor = System.Drawing.Color.White;
            this.gbText.Location = new System.Drawing.Point(12, 361);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(671, 180);
            this.gbText.TabIndex = 4;
            this.gbText.TabStop = false;
            this.gbText.Text = "Text";
            this.gbText.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(658, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // TimerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerTab";
            this.Text = "TimerTab";
            this.groupBox2.ResumeLayout(false);
            this.gbText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTimes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbProfiles;
        private Bunifu.Framework.UI.BunifuFlatButton bProfilErstellen;
        private Bunifu.Framework.UI.BunifuFlatButton bProfilLöschen;
        private Bunifu.Framework.UI.BunifuFlatButton bZeitEntfernen;
        private Bunifu.Framework.UI.BunifuFlatButton bZeitHinzufügen;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
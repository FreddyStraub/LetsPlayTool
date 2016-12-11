namespace LetsPlayTool.Dialogs
{
    partial class TimeDilaog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeDilaog));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.nudTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudTimeMSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudTimeHours = new System.Windows.Forms.NumericUpDown();
            this.bFarbe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bAbbrechen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bFertig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cdFarbe = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelText = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.checkText = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbLoop = new System.Windows.Forms.Label();
            this.checkLoop = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbStunden = new System.Windows.Forms.Label();
            this.lbMinuten = new System.Windows.Forms.Label();
            this.lbSekunden = new System.Windows.Forms.Label();
            this.lbMillisekunden = new System.Windows.Forms.Label();
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHours)).BeginInit();
            this.panelText.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(383, 52);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(335, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // nudTimeSeconds
            // 
            this.nudTimeSeconds.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeSeconds.ForeColor = System.Drawing.Color.White;
            this.nudTimeSeconds.Location = new System.Drawing.Point(196, 95);
            this.nudTimeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeSeconds.Name = "nudTimeSeconds";
            this.nudTimeSeconds.Size = new System.Drawing.Size(86, 31);
            this.nudTimeSeconds.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nudTimeSeconds, "Sekunden");
            // 
            // nudTimeMinutes
            // 
            this.nudTimeMinutes.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeMinutes.ForeColor = System.Drawing.Color.White;
            this.nudTimeMinutes.Location = new System.Drawing.Point(104, 95);
            this.nudTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeMinutes.Name = "nudTimeMinutes";
            this.nudTimeMinutes.Size = new System.Drawing.Size(86, 31);
            this.nudTimeMinutes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nudTimeMinutes, "Minuten");
            // 
            // nudTimeMSeconds
            // 
            this.nudTimeMSeconds.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeMSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeMSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeMSeconds.ForeColor = System.Drawing.Color.White;
            this.nudTimeMSeconds.Location = new System.Drawing.Point(288, 95);
            this.nudTimeMSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeMSeconds.Name = "nudTimeMSeconds";
            this.nudTimeMSeconds.Size = new System.Drawing.Size(86, 31);
            this.nudTimeMSeconds.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nudTimeMSeconds, "Millisekunden");
            // 
            // nudTimeHours
            // 
            this.nudTimeHours.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeHours.ForeColor = System.Drawing.Color.White;
            this.nudTimeHours.Location = new System.Drawing.Point(12, 95);
            this.nudTimeHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeHours.Name = "nudTimeHours";
            this.nudTimeHours.Size = new System.Drawing.Size(86, 31);
            this.nudTimeHours.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nudTimeHours, "Stunden");
            // 
            // bFarbe
            // 
            this.bFarbe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFarbe.BorderRadius = 0;
            this.bFarbe.ButtonText = "     Farbe";
            this.bFarbe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFarbe.DisabledColor = System.Drawing.Color.Gray;
            this.bFarbe.Iconcolor = System.Drawing.Color.Transparent;
            this.bFarbe.Iconimage = null;
            this.bFarbe.Iconimage_right = null;
            this.bFarbe.Iconimage_right_Selected = null;
            this.bFarbe.Iconimage_Selected = null;
            this.bFarbe.IconMarginLeft = 0;
            this.bFarbe.IconMarginRight = 0;
            this.bFarbe.IconRightVisible = true;
            this.bFarbe.IconRightZoom = 0D;
            this.bFarbe.IconVisible = true;
            this.bFarbe.IconZoom = 90D;
            this.bFarbe.IsTab = false;
            this.bFarbe.Location = new System.Drawing.Point(12, 174);
            this.bFarbe.Name = "bFarbe";
            this.bFarbe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFarbe.OnHoverTextColor = System.Drawing.Color.White;
            this.bFarbe.Padding = new System.Windows.Forms.Padding(129, 0, 0, 0);
            this.bFarbe.selected = false;
            this.bFarbe.Size = new System.Drawing.Size(358, 31);
            this.bFarbe.TabIndex = 5;
            this.bFarbe.Text = "     Farbe";
            this.bFarbe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bFarbe.Textcolor = System.Drawing.Color.White;
            this.bFarbe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFarbe.Click += new System.EventHandler(this.bFarbe_Click);
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAbbrechen.BorderRadius = 0;
            this.bAbbrechen.ButtonText = "  Abbrechen";
            this.bAbbrechen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAbbrechen.DisabledColor = System.Drawing.Color.Gray;
            this.bAbbrechen.Iconcolor = System.Drawing.Color.Transparent;
            this.bAbbrechen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bAbbrechen.Iconimage")));
            this.bAbbrechen.Iconimage_right = null;
            this.bAbbrechen.Iconimage_right_Selected = null;
            this.bAbbrechen.Iconimage_Selected = null;
            this.bAbbrechen.IconMarginLeft = 0;
            this.bAbbrechen.IconMarginRight = 0;
            this.bAbbrechen.IconRightVisible = true;
            this.bAbbrechen.IconRightZoom = 0D;
            this.bAbbrechen.IconVisible = true;
            this.bAbbrechen.IconZoom = 80D;
            this.bAbbrechen.IsTab = false;
            this.bAbbrechen.Location = new System.Drawing.Point(251, 397);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bAbbrechen.OnHoverTextColor = System.Drawing.Color.White;
            this.bAbbrechen.selected = false;
            this.bAbbrechen.Size = new System.Drawing.Size(123, 38);
            this.bAbbrechen.TabIndex = 7;
            this.bAbbrechen.Text = "  Abbrechen";
            this.bAbbrechen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAbbrechen.Textcolor = System.Drawing.Color.White;
            this.bAbbrechen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAbbrechen.Click += new System.EventHandler(this.bAbbrechen_Click);
            // 
            // bFertig
            // 
            this.bFertig.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bFertig.BackColor = System.Drawing.Color.DodgerBlue;
            this.bFertig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFertig.BorderRadius = 0;
            this.bFertig.ButtonText = "     Fertig";
            this.bFertig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFertig.DisabledColor = System.Drawing.Color.Gray;
            this.bFertig.Iconcolor = System.Drawing.Color.Transparent;
            this.bFertig.Iconimage = ((System.Drawing.Image)(resources.GetObject("bFertig.Iconimage")));
            this.bFertig.Iconimage_right = null;
            this.bFertig.Iconimage_right_Selected = null;
            this.bFertig.Iconimage_Selected = null;
            this.bFertig.IconMarginLeft = 0;
            this.bFertig.IconMarginRight = 0;
            this.bFertig.IconRightVisible = true;
            this.bFertig.IconRightZoom = 0D;
            this.bFertig.IconVisible = true;
            this.bFertig.IconZoom = 80D;
            this.bFertig.IsTab = false;
            this.bFertig.Location = new System.Drawing.Point(122, 397);
            this.bFertig.Name = "bFertig";
            this.bFertig.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bFertig.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bFertig.OnHoverTextColor = System.Drawing.Color.White;
            this.bFertig.selected = false;
            this.bFertig.Size = new System.Drawing.Size(123, 38);
            this.bFertig.TabIndex = 6;
            this.bFertig.Text = "     Fertig";
            this.bFertig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bFertig.Textcolor = System.Drawing.Color.White;
            this.bFertig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFertig.Click += new System.EventHandler(this.bFertig_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.ReshowDelay = 100;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(362, 128);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.richTextBox1);
            this.panelText.Enabled = false;
            this.panelText.Location = new System.Drawing.Point(12, 241);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(362, 136);
            this.panelText.TabIndex = 9;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(35, 216);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(34, 16);
            this.lbText.TabIndex = 18;
            this.lbText.Text = "Text";
            // 
            // checkText
            // 
            this.checkText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkText.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkText.Checked = false;
            this.checkText.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkText.ForeColor = System.Drawing.Color.White;
            this.checkText.Location = new System.Drawing.Point(13, 214);
            this.checkText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkText.Name = "checkText";
            this.checkText.Size = new System.Drawing.Size(20, 20);
            this.checkText.TabIndex = 17;
            this.checkText.OnChange += new System.EventHandler(this.checkShift_OnChange);
            // 
            // lbLoop
            // 
            this.lbLoop.AutoSize = true;
            this.lbLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoop.ForeColor = System.Drawing.Color.White;
            this.lbLoop.Location = new System.Drawing.Point(34, 146);
            this.lbLoop.Name = "lbLoop";
            this.lbLoop.Size = new System.Drawing.Size(39, 16);
            this.lbLoop.TabIndex = 20;
            this.lbLoop.Text = "Loop";
            // 
            // checkLoop
            // 
            this.checkLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkLoop.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkLoop.Checked = false;
            this.checkLoop.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLoop.ForeColor = System.Drawing.Color.White;
            this.checkLoop.Location = new System.Drawing.Point(12, 144);
            this.checkLoop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLoop.Name = "checkLoop";
            this.checkLoop.Size = new System.Drawing.Size(20, 20);
            this.checkLoop.TabIndex = 19;
            // 
            // lbStunden
            // 
            this.lbStunden.AutoSize = true;
            this.lbStunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStunden.ForeColor = System.Drawing.Color.White;
            this.lbStunden.Location = new System.Drawing.Point(9, 76);
            this.lbStunden.Name = "lbStunden";
            this.lbStunden.Size = new System.Drawing.Size(60, 16);
            this.lbStunden.TabIndex = 21;
            this.lbStunden.Text = "Stunden:";
            // 
            // lbMinuten
            // 
            this.lbMinuten.AutoSize = true;
            this.lbMinuten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinuten.ForeColor = System.Drawing.Color.White;
            this.lbMinuten.Location = new System.Drawing.Point(101, 76);
            this.lbMinuten.Name = "lbMinuten";
            this.lbMinuten.Size = new System.Drawing.Size(57, 16);
            this.lbMinuten.TabIndex = 22;
            this.lbMinuten.Text = "Minuten:";
            // 
            // lbSekunden
            // 
            this.lbSekunden.AutoSize = true;
            this.lbSekunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSekunden.ForeColor = System.Drawing.Color.White;
            this.lbSekunden.Location = new System.Drawing.Point(193, 76);
            this.lbSekunden.Name = "lbSekunden";
            this.lbSekunden.Size = new System.Drawing.Size(72, 16);
            this.lbSekunden.TabIndex = 23;
            this.lbSekunden.Text = "Sekunden:";
            // 
            // lbMillisekunden
            // 
            this.lbMillisekunden.AutoSize = true;
            this.lbMillisekunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMillisekunden.ForeColor = System.Drawing.Color.White;
            this.lbMillisekunden.Location = new System.Drawing.Point(285, 76);
            this.lbMillisekunden.Name = "lbMillisekunden";
            this.lbMillisekunden.Size = new System.Drawing.Size(93, 16);
            this.lbMillisekunden.TabIndex = 24;
            this.lbMillisekunden.Text = "Millisekunden:";
            this.lbMillisekunden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeDilaog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(383, 447);
            this.Controls.Add(this.lbMillisekunden);
            this.Controls.Add(this.lbSekunden);
            this.Controls.Add(this.lbMinuten);
            this.Controls.Add(this.lbStunden);
            this.Controls.Add(this.lbLoop);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.checkText);
            this.Controls.Add(this.checkLoop);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bFertig);
            this.Controls.Add(this.bFarbe);
            this.Controls.Add(this.nudTimeSeconds);
            this.Controls.Add(this.nudTimeMinutes);
            this.Controls.Add(this.nudTimeMSeconds);
            this.Controls.Add(this.nudTimeHours);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TimeDilaog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeDilaog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimeDilaog_KeyDown);
            this.HeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHours)).EndInit();
            this.panelText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bAbbrechen;
        private Bunifu.Framework.UI.BunifuFlatButton bFertig;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbText;
        public System.Windows.Forms.NumericUpDown nudTimeSeconds;
        public System.Windows.Forms.NumericUpDown nudTimeMinutes;
        public System.Windows.Forms.NumericUpDown nudTimeMSeconds;
        public System.Windows.Forms.NumericUpDown nudTimeHours;
        public Bunifu.Framework.UI.BunifuFlatButton bFarbe;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public Bunifu.Framework.UI.BunifuCheckbox checkText;
        public System.Windows.Forms.Panel panelText;
        public System.Windows.Forms.ColorDialog cdFarbe;
        private System.Windows.Forms.Label lbLoop;
        public Bunifu.Framework.UI.BunifuCheckbox checkLoop;
        private System.Windows.Forms.Label lbStunden;
        private System.Windows.Forms.Label lbMinuten;
        private System.Windows.Forms.Label lbSekunden;
        private System.Windows.Forms.Label lbMillisekunden;
    }
}
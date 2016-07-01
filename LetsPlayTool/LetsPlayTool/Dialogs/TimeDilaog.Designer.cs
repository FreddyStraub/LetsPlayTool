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
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeMSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeHours)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(351, 52);
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(307, 8);
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
            this.nudTimeSeconds.Location = new System.Drawing.Point(180, 74);
            this.nudTimeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeSeconds.Name = "nudTimeSeconds";
            this.nudTimeSeconds.Size = new System.Drawing.Size(78, 31);
            this.nudTimeSeconds.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nudTimeSeconds, "Sekunden");
            // 
            // nudTimeMinutes
            // 
            this.nudTimeMinutes.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeMinutes.ForeColor = System.Drawing.Color.White;
            this.nudTimeMinutes.Location = new System.Drawing.Point(96, 74);
            this.nudTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeMinutes.Name = "nudTimeMinutes";
            this.nudTimeMinutes.Size = new System.Drawing.Size(78, 31);
            this.nudTimeMinutes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nudTimeMinutes, "Minuten");
            // 
            // nudTimeMSeconds
            // 
            this.nudTimeMSeconds.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeMSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeMSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeMSeconds.ForeColor = System.Drawing.Color.White;
            this.nudTimeMSeconds.Location = new System.Drawing.Point(264, 74);
            this.nudTimeMSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeMSeconds.Name = "nudTimeMSeconds";
            this.nudTimeMSeconds.Size = new System.Drawing.Size(78, 31);
            this.nudTimeMSeconds.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nudTimeMSeconds, "Millisekunden");
            // 
            // nudTimeHours
            // 
            this.nudTimeHours.BackColor = System.Drawing.Color.DodgerBlue;
            this.nudTimeHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimeHours.ForeColor = System.Drawing.Color.White;
            this.nudTimeHours.Location = new System.Drawing.Point(12, 74);
            this.nudTimeHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeHours.Name = "nudTimeHours";
            this.nudTimeHours.Size = new System.Drawing.Size(78, 31);
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
            this.bFarbe.Iconcolor = System.Drawing.Color.Transparent;
            this.bFarbe.Iconimage = null;
            this.bFarbe.Iconimage_right = null;
            this.bFarbe.Iconimage_right_Selected = null;
            this.bFarbe.Iconimage_Selected = null;
            this.bFarbe.IsTab = false;
            this.bFarbe.Location = new System.Drawing.Point(12, 120);
            this.bFarbe.Name = "bFarbe";
            this.bFarbe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bFarbe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFarbe.OnHoverTextColor = System.Drawing.Color.White;
            this.bFarbe.Padding = new System.Windows.Forms.Padding(129, 0, 0, 0);
            this.bFarbe.selected = false;
            this.bFarbe.Size = new System.Drawing.Size(330, 31);
            this.bFarbe.TabIndex = 5;
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
            this.bAbbrechen.Iconcolor = System.Drawing.Color.Transparent;
            this.bAbbrechen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bAbbrechen.Iconimage")));
            this.bAbbrechen.Iconimage_right = null;
            this.bAbbrechen.Iconimage_right_Selected = null;
            this.bAbbrechen.Iconimage_Selected = null;
            this.bAbbrechen.IsTab = false;
            this.bAbbrechen.Location = new System.Drawing.Point(219, 197);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bAbbrechen.OnHoverTextColor = System.Drawing.Color.White;
            this.bAbbrechen.selected = false;
            this.bAbbrechen.Size = new System.Drawing.Size(123, 38);
            this.bAbbrechen.TabIndex = 7;
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
            this.bFertig.Iconcolor = System.Drawing.Color.Transparent;
            this.bFertig.Iconimage = ((System.Drawing.Image)(resources.GetObject("bFertig.Iconimage")));
            this.bFertig.Iconimage_right = null;
            this.bFertig.Iconimage_right_Selected = null;
            this.bFertig.Iconimage_Selected = null;
            this.bFertig.IsTab = false;
            this.bFertig.Location = new System.Drawing.Point(90, 197);
            this.bFertig.Name = "bFertig";
            this.bFertig.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bFertig.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bFertig.OnHoverTextColor = System.Drawing.Color.White;
            this.bFertig.selected = false;
            this.bFertig.Size = new System.Drawing.Size(123, 38);
            this.bFertig.TabIndex = 6;
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
            // TimeDilaog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(351, 247);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bFertig);
            this.Controls.Add(this.bFarbe);
            this.Controls.Add(this.nudTimeSeconds);
            this.Controls.Add(this.nudTimeMinutes);
            this.Controls.Add(this.nudTimeMSeconds);
            this.Controls.Add(this.nudTimeHours);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.NumericUpDown nudTimeSeconds;
        private System.Windows.Forms.NumericUpDown nudTimeMinutes;
        private System.Windows.Forms.NumericUpDown nudTimeMSeconds;
        private System.Windows.Forms.NumericUpDown nudTimeHours;
        private Bunifu.Framework.UI.BunifuFlatButton bFarbe;
        private Bunifu.Framework.UI.BunifuFlatButton bAbbrechen;
        private Bunifu.Framework.UI.BunifuFlatButton bFertig;
        private System.Windows.Forms.ColorDialog cdFarbe;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
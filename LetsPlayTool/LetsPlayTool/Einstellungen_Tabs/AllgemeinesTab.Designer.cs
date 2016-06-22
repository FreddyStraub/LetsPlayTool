namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class AllgemeinesTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllgemeinesTab));
            this.gbHotkey = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAufnhameStop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bAufnhameStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelÜFensterSettings = new System.Windows.Forms.Panel();
            this.checkÜFensterTimer = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.switchÜFenster = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.switchIErinerrungen = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.tbIErinerrungen = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbHotkey.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelÜFensterSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHotkey
            // 
            this.gbHotkey.Controls.Add(this.label3);
            this.gbHotkey.Controls.Add(this.label2);
            this.gbHotkey.Controls.Add(this.label1);
            this.gbHotkey.Controls.Add(this.bAufnhameStop);
            this.gbHotkey.Controls.Add(this.bAufnhameStart);
            this.gbHotkey.ForeColor = System.Drawing.Color.White;
            this.gbHotkey.Location = new System.Drawing.Point(12, 12);
            this.gbHotkey.Name = "gbHotkey";
            this.gbHotkey.Size = new System.Drawing.Size(671, 180);
            this.gbHotkey.TabIndex = 0;
            this.gbHotkey.TabStop = false;
            this.gbHotkey.Text = "Aufnhamehotkeys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aufnahme Stop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aufnahme Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotkeys für das Starten/Stoppem der Aufnahme. Damit wird auch der Timer aktiviert" +
    ".";
            // 
            // bAufnhameStop
            // 
            this.bAufnhameStop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAufnhameStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAufnhameStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAufnhameStop.BorderRadius = 0;
            this.bAufnhameStop.ButtonText = "NumPad0";
            this.bAufnhameStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAufnhameStop.Iconcolor = System.Drawing.Color.Transparent;
            this.bAufnhameStop.Iconimage = null;
            this.bAufnhameStop.Iconimage_right = null;
            this.bAufnhameStop.Iconimage_right_Selected = null;
            this.bAufnhameStop.Iconimage_Selected = null;
            this.bAufnhameStop.IsTab = false;
            this.bAufnhameStop.Location = new System.Drawing.Point(128, 61);
            this.bAufnhameStop.Name = "bAufnhameStop";
            this.bAufnhameStop.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAufnhameStop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAufnhameStop.OnHoverTextColor = System.Drawing.Color.White;
            this.bAufnhameStop.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.bAufnhameStop.selected = false;
            this.bAufnhameStop.Size = new System.Drawing.Size(133, 57);
            this.bAufnhameStop.TabIndex = 4;
            this.bAufnhameStop.Textcolor = System.Drawing.Color.White;
            this.bAufnhameStop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAufnhameStop.Click += new System.EventHandler(this.bAufnhameStop_Click);
            // 
            // bAufnhameStart
            // 
            this.bAufnhameStart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAufnhameStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAufnhameStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAufnhameStart.BorderRadius = 0;
            this.bAufnhameStart.ButtonText = "NumPad0";
            this.bAufnhameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAufnhameStart.Iconcolor = System.Drawing.Color.Transparent;
            this.bAufnhameStart.Iconimage = null;
            this.bAufnhameStart.Iconimage_right = null;
            this.bAufnhameStart.Iconimage_right_Selected = null;
            this.bAufnhameStart.Iconimage_Selected = null;
            this.bAufnhameStart.IsTab = false;
            this.bAufnhameStart.Location = new System.Drawing.Point(402, 64);
            this.bAufnhameStart.Name = "bAufnhameStart";
            this.bAufnhameStart.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAufnhameStart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bAufnhameStart.OnHoverTextColor = System.Drawing.Color.White;
            this.bAufnhameStart.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.bAufnhameStart.selected = false;
            this.bAufnhameStart.Size = new System.Drawing.Size(133, 57);
            this.bAufnhameStart.TabIndex = 3;
            this.bAufnhameStart.Textcolor = System.Drawing.Color.White;
            this.bAufnhameStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelÜFensterSettings);
            this.groupBox1.Controls.Add(this.switchÜFenster);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 109);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Überwachungsfenster";
            // 
            // panelÜFensterSettings
            // 
            this.panelÜFensterSettings.Controls.Add(this.checkÜFensterTimer);
            this.panelÜFensterSettings.Controls.Add(this.label4);
            this.panelÜFensterSettings.Location = new System.Drawing.Point(61, 57);
            this.panelÜFensterSettings.Name = "panelÜFensterSettings";
            this.panelÜFensterSettings.Size = new System.Drawing.Size(524, 46);
            this.panelÜFensterSettings.TabIndex = 20;
            // 
            // checkÜFensterTimer
            // 
            this.checkÜFensterTimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterTimer.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkÜFensterTimer.Checked = true;
            this.checkÜFensterTimer.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkÜFensterTimer.ForeColor = System.Drawing.Color.White;
            this.checkÜFensterTimer.Location = new System.Drawing.Point(4, 13);
            this.checkÜFensterTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkÜFensterTimer.Name = "checkÜFensterTimer";
            this.checkÜFensterTimer.Size = new System.Drawing.Size(20, 20);
            this.checkÜFensterTimer.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Timer anzeigen";
            // 
            // switchÜFenster
            // 
            this.switchÜFenster.BackColor = System.Drawing.Color.Transparent;
            this.switchÜFenster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchÜFenster.BackgroundImage")));
            this.switchÜFenster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchÜFenster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchÜFenster.Location = new System.Drawing.Point(12, 31);
            this.switchÜFenster.Name = "switchÜFenster";
            this.switchÜFenster.OffColor = System.Drawing.Color.Gray;
            this.switchÜFenster.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchÜFenster.Size = new System.Drawing.Size(43, 25);
            this.switchÜFenster.TabIndex = 6;
            this.switchÜFenster.Value = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(524, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kleines Überwachungsfenster welches visuelle Rückmeldung zum aktuellen Status gib" +
    "t.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.switchIErinerrungen);
            this.groupBox2.Controls.Add(this.tbIErinerrungen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Individuelle Erinerrungen";
            // 
            // switchIErinerrungen
            // 
            this.switchIErinerrungen.BackColor = System.Drawing.Color.Transparent;
            this.switchIErinerrungen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchIErinerrungen.BackgroundImage")));
            this.switchIErinerrungen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchIErinerrungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchIErinerrungen.Location = new System.Drawing.Point(12, 26);
            this.switchIErinerrungen.Name = "switchIErinerrungen";
            this.switchIErinerrungen.OffColor = System.Drawing.Color.Gray;
            this.switchIErinerrungen.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchIErinerrungen.Size = new System.Drawing.Size(43, 25);
            this.switchIErinerrungen.TabIndex = 5;
            this.switchIErinerrungen.Value = true;
            // 
            // tbIErinerrungen
            // 
            this.tbIErinerrungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbIErinerrungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIErinerrungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIErinerrungen.ForeColor = System.Drawing.Color.White;
            this.tbIErinerrungen.Location = new System.Drawing.Point(12, 63);
            this.tbIErinerrungen.Name = "tbIErinerrungen";
            this.tbIErinerrungen.Size = new System.Drawing.Size(644, 157);
            this.tbIErinerrungen.TabIndex = 4;
            this.tbIErinerrungen.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Individuelle Errinerung die beim Start der Aufnahme angezeigt wird.";
            // 
            // AllgemeinesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHotkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AllgemeinesTab";
            this.Text = "AllgemeinesTab";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllgemeinesTab_KeyDown);
            this.gbHotkey.ResumeLayout(false);
            this.gbHotkey.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelÜFensterSettings.ResumeLayout(false);
            this.panelÜFensterSettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHotkey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bAufnhameStop;
        private Bunifu.Framework.UI.BunifuFlatButton bAufnhameStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tbIErinerrungen;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchÜFenster;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchIErinerrungen;
        private System.Windows.Forms.Panel panelÜFensterSettings;
        private Bunifu.Framework.UI.BunifuCheckbox checkÜFensterTimer;
        private System.Windows.Forms.Label label4;
    }
}
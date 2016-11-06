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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllgemeinesTab));
            this.gbHotkey = new System.Windows.Forms.GroupBox();
            this.bAufnhameStop = new System.Windows.Forms.Button();
            this.bAufnhameStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelÜFensterSettings = new System.Windows.Forms.Panel();
            this.checkÜFensterRAM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkÜFensterCPU = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbCPU = new System.Windows.Forms.Label();
            this.checkÜFensterTimer = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.switchÜFenster = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.switchIErinerrungen = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.tbIErinerrungen = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbHotkey.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelÜFensterSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHotkey
            // 
            this.gbHotkey.Controls.Add(this.bAufnhameStop);
            this.gbHotkey.Controls.Add(this.bAufnhameStart);
            this.gbHotkey.Controls.Add(this.label3);
            this.gbHotkey.Controls.Add(this.label2);
            this.gbHotkey.Controls.Add(this.label1);
            this.gbHotkey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHotkey.ForeColor = System.Drawing.Color.White;
            this.gbHotkey.Location = new System.Drawing.Point(12, 12);
            this.gbHotkey.Name = "gbHotkey";
            this.gbHotkey.Size = new System.Drawing.Size(671, 180);
            this.gbHotkey.TabIndex = 0;
            this.gbHotkey.TabStop = false;
            this.gbHotkey.Text = "Aufnhamehotkeys";
            // 
            // bAufnhameStop
            // 
            this.bAufnhameStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAufnhameStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAufnhameStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAufnhameStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAufnhameStop.ForeColor = System.Drawing.Color.White;
            this.bAufnhameStop.Location = new System.Drawing.Point(402, 61);
            this.bAufnhameStop.Name = "bAufnhameStop";
            this.bAufnhameStop.Size = new System.Drawing.Size(133, 57);
            this.bAufnhameStop.TabIndex = 20;
            this.bAufnhameStop.Text = "NumPad0";
            this.bAufnhameStop.UseVisualStyleBackColor = false;
            this.bAufnhameStop.Click += new System.EventHandler(this.bAufnhameStop_Click);
            // 
            // bAufnhameStart
            // 
            this.bAufnhameStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAufnhameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAufnhameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAufnhameStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAufnhameStart.ForeColor = System.Drawing.Color.White;
            this.bAufnhameStart.Location = new System.Drawing.Point(128, 61);
            this.bAufnhameStart.Name = "bAufnhameStart";
            this.bAufnhameStart.Size = new System.Drawing.Size(133, 57);
            this.bAufnhameStart.TabIndex = 19;
            this.bAufnhameStart.Text = "NumPad0";
            this.bAufnhameStart.UseVisualStyleBackColor = false;
            this.bAufnhameStart.Click += new System.EventHandler(this.bAufnhameStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aufnahme Stop:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aufnahme Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotkeys für das Starten/Stoppen der Aufnahme. Damit wird auch der Timer aktiviert" +
    ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelÜFensterSettings);
            this.groupBox1.Controls.Add(this.switchÜFenster);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelÜFensterSettings.Controls.Add(this.checkÜFensterRAM);
            this.panelÜFensterSettings.Controls.Add(this.label5);
            this.panelÜFensterSettings.Controls.Add(this.checkÜFensterCPU);
            this.panelÜFensterSettings.Controls.Add(this.lbCPU);
            this.panelÜFensterSettings.Controls.Add(this.checkÜFensterTimer);
            this.panelÜFensterSettings.Controls.Add(this.label4);
            this.panelÜFensterSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelÜFensterSettings.Location = new System.Drawing.Point(61, 57);
            this.panelÜFensterSettings.Name = "panelÜFensterSettings";
            this.panelÜFensterSettings.Size = new System.Drawing.Size(524, 46);
            this.panelÜFensterSettings.TabIndex = 20;
            // 
            // checkÜFensterRAM
            // 
            this.checkÜFensterRAM.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterRAM.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkÜFensterRAM.Checked = true;
            this.checkÜFensterRAM.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterRAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkÜFensterRAM.ForeColor = System.Drawing.Color.White;
            this.checkÜFensterRAM.Location = new System.Drawing.Point(257, 13);
            this.checkÜFensterRAM.Margin = new System.Windows.Forms.Padding(4);
            this.checkÜFensterRAM.Name = "checkÜFensterRAM";
            this.checkÜFensterRAM.Size = new System.Drawing.Size(20, 20);
            this.checkÜFensterRAM.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Freier RAM";
            // 
            // checkÜFensterCPU
            // 
            this.checkÜFensterCPU.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterCPU.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkÜFensterCPU.Checked = true;
            this.checkÜFensterCPU.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterCPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkÜFensterCPU.ForeColor = System.Drawing.Color.White;
            this.checkÜFensterCPU.Location = new System.Drawing.Point(135, 13);
            this.checkÜFensterCPU.Margin = new System.Windows.Forms.Padding(4);
            this.checkÜFensterCPU.Name = "checkÜFensterCPU";
            this.checkÜFensterCPU.Size = new System.Drawing.Size(20, 20);
            this.checkÜFensterCPU.TabIndex = 20;
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPU.Location = new System.Drawing.Point(162, 15);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(88, 17);
            this.lbCPU.TabIndex = 21;
            this.lbCPU.Text = "CPU anzeigen";
            // 
            // checkÜFensterTimer
            // 
            this.checkÜFensterTimer.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterTimer.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkÜFensterTimer.Checked = true;
            this.checkÜFensterTimer.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkÜFensterTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkÜFensterTimer.ForeColor = System.Drawing.Color.White;
            this.checkÜFensterTimer.Location = new System.Drawing.Point(4, 13);
            this.checkÜFensterTimer.Margin = new System.Windows.Forms.Padding(4);
            this.checkÜFensterTimer.Name = "checkÜFensterTimer";
            this.checkÜFensterTimer.Size = new System.Drawing.Size(20, 20);
            this.checkÜFensterTimer.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Timer anzeigen";
            // 
            // switchÜFenster
            // 
            this.switchÜFenster.BackColor = System.Drawing.Color.Transparent;
            this.switchÜFenster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchÜFenster.BackgroundImage")));
            this.switchÜFenster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchÜFenster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchÜFenster.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchÜFenster.Location = new System.Drawing.Point(12, 33);
            this.switchÜFenster.Name = "switchÜFenster";
            this.switchÜFenster.OffColor = System.Drawing.Color.Gray;
            this.switchÜFenster.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchÜFenster.Size = new System.Drawing.Size(43, 25);
            this.switchÜFenster.TabIndex = 6;
            this.switchÜFenster.Value = true;
            this.switchÜFenster.OnValueChange += new System.EventHandler(this.switchÜFenster_OnValueChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(508, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kleines Überwachungsfenster welches visuelle Rückmeldung zum aktuellen Status gib" +
    "t.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDuration);
            this.groupBox2.Controls.Add(this.nudDuration);
            this.groupBox2.Controls.Add(this.switchIErinerrungen);
            this.groupBox2.Controls.Add(this.tbIErinerrungen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Individuelle Erinerrungen";
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.ForeColor = System.Drawing.Color.White;
            this.lbDuration.Location = new System.Drawing.Point(506, 32);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(91, 17);
            this.lbDuration.TabIndex = 7;
            this.lbDuration.Text = "Anzeigedauer:";
            // 
            // nudDuration
            // 
            this.nudDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.nudDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDuration.ForeColor = System.Drawing.Color.White;
            this.nudDuration.Location = new System.Drawing.Point(600, 32);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(56, 21);
            this.nudDuration.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nudDuration, "Anzeigedauer der Nachricht in Sekunden");
            // 
            // switchIErinerrungen
            // 
            this.switchIErinerrungen.BackColor = System.Drawing.Color.Transparent;
            this.switchIErinerrungen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchIErinerrungen.BackgroundImage")));
            this.switchIErinerrungen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchIErinerrungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchIErinerrungen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchIErinerrungen.Location = new System.Drawing.Point(12, 28);
            this.switchIErinerrungen.Name = "switchIErinerrungen";
            this.switchIErinerrungen.OffColor = System.Drawing.Color.Gray;
            this.switchIErinerrungen.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchIErinerrungen.Size = new System.Drawing.Size(43, 25);
            this.switchIErinerrungen.TabIndex = 5;
            this.switchIErinerrungen.Value = true;
            this.switchIErinerrungen.OnValueChange += new System.EventHandler(this.switchIErinerrungen_OnValueChange);
            // 
            // tbIErinerrungen
            // 
            this.tbIErinerrungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbIErinerrungen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIErinerrungen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 17);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHotkey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button bAufnhameStop;
        private System.Windows.Forms.Button bAufnhameStart;
        private Bunifu.Framework.UI.BunifuCheckbox checkÜFensterCPU;
        private System.Windows.Forms.Label lbCPU;
        private Bunifu.Framework.UI.BunifuCheckbox checkÜFensterRAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
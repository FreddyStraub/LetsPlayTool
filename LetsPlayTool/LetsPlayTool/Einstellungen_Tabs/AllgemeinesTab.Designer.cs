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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.switchIErinerrungen = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.tbIErinerrungen = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbHotkey.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDuration);
            this.groupBox2.Controls.Add(this.nudDuration);
            this.groupBox2.Controls.Add(this.switchIErinerrungen);
            this.groupBox2.Controls.Add(this.tbIErinerrungen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
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
            this.lbDuration.Location = new System.Drawing.Point(471, 32);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(123, 17);
            this.lbDuration.TabIndex = 7;
            this.lbDuration.Text = "Anzeigedauer in (s):";
            this.toolTip1.SetToolTip(this.lbDuration, "Anzeigedauer in Sekunden");
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
            this.toolTip1.SetToolTip(this.nudDuration, "Anzeigedauer in Sekunden");
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
            this.label7.Location = new System.Drawing.Point(59, 32);
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
            this.Controls.Add(this.gbHotkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AllgemeinesTab";
            this.Text = "AllgemeinesTab";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AllgemeinesTab_KeyDown);
            this.gbHotkey.ResumeLayout(false);
            this.gbHotkey.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tbIErinerrungen;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchIErinerrungen;
        private System.Windows.Forms.Button bAufnhameStop;
        private System.Windows.Forms.Button bAufnhameStart;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
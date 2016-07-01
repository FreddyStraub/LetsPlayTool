namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class MarkerTab
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
            this.tbSpeicherort = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFormat = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bKey = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkShift = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkAlt = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkStrg = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fbdSpeicherort = new Ookii.Dialogs.VistaFolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSpeicherort
            // 
            this.tbSpeicherort.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbSpeicherort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSpeicherort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpeicherort.ForeColor = System.Drawing.Color.White;
            this.tbSpeicherort.Location = new System.Drawing.Point(94, 37);
            this.tbSpeicherort.Multiline = true;
            this.tbSpeicherort.Name = "tbSpeicherort";
            this.tbSpeicherort.ReadOnly = true;
            this.tbSpeicherort.Size = new System.Drawing.Size(516, 25);
            this.tbSpeicherort.TabIndex = 0;
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.bBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.ForeColor = System.Drawing.Color.White;
            this.bBrowse.Location = new System.Drawing.Point(616, 37);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(30, 25);
            this.bBrowse.TabIndex = 1;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFormat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSpeicherort);
            this.groupBox1.Controls.Add(this.bBrowse);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 320);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marker";
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.Transparent;
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.Items = new string[] {
        "Textdatei (.txt)",
        "Audiodatei (.wav)"};
            this.cbFormat.Location = new System.Drawing.Point(94, 101);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.NomalColor = System.Drawing.Color.DodgerBlue;
            this.cbFormat.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.cbFormat.selectedIndex = 0;
            this.cbFormat.Size = new System.Drawing.Size(217, 26);
            this.cbFormat.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Format:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkShift);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkAlt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkStrg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 164);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotkey";
            // 
            // bKey
            // 
            this.bKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.bKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKey.ForeColor = System.Drawing.Color.White;
            this.bKey.Location = new System.Drawing.Point(264, 70);
            this.bKey.Name = "bKey";
            this.bKey.Size = new System.Drawing.Size(133, 57);
            this.bKey.TabIndex = 18;
            this.bKey.Text = "NumPad0";
            this.bKey.UseVisualStyleBackColor = false;
            this.bKey.Click += new System.EventHandler(this.bKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Shift";
            // 
            // checkShift
            // 
            this.checkShift.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkShift.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkShift.Checked = true;
            this.checkShift.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShift.ForeColor = System.Drawing.Color.White;
            this.checkShift.Location = new System.Drawing.Point(172, 86);
            this.checkShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkShift.Name = "checkShift";
            this.checkShift.Size = new System.Drawing.Size(20, 20);
            this.checkShift.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Alt";
            // 
            // checkAlt
            // 
            this.checkAlt.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkAlt.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkAlt.Checked = true;
            this.checkAlt.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAlt.ForeColor = System.Drawing.Color.White;
            this.checkAlt.Location = new System.Drawing.Point(105, 86);
            this.checkAlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAlt.Name = "checkAlt";
            this.checkAlt.Size = new System.Drawing.Size(20, 20);
            this.checkAlt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strg";
            // 
            // checkStrg
            // 
            this.checkStrg.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkStrg.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkStrg.Checked = true;
            this.checkStrg.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkStrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStrg.ForeColor = System.Drawing.Color.White;
            this.checkStrg.Location = new System.Drawing.Point(28, 86);
            this.checkStrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkStrg.Name = "checkStrg";
            this.checkStrg.Size = new System.Drawing.Size(20, 20);
            this.checkStrg.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hotkey um einen Marker zu setzen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speicherort:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Marker helfen dir wichtige stellen im Video später beim Schnitt schneller wieder " +
    "zu finden.\r\n";
            // 
            // MarkerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MarkerTab";
            this.Text = "MarkerTab";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MarkerTab_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSpeicherort;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCheckbox checkStrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox checkShift;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox checkAlt;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown cbFormat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bKey;
        private Ookii.Dialogs.VistaFolderBrowserDialog fbdSpeicherort;
    }
}
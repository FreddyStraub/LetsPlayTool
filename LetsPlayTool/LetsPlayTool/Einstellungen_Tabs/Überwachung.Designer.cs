﻿namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class Überwachung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Überwachung));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAufnahmeOrdnerÖffnen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbOrdnerÖffnen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAufnahmeordner = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFRam = new System.Windows.Forms.Label();
            this.switchRAM = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.switchCPU = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.fbdAufnahmeordner = new Ookii.Dialogs.VistaFolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelÜFensterSettings = new System.Windows.Forms.Panel();
            this.checkÜFensterRAM = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkÜFensterCPU = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbCPU = new System.Windows.Forms.Label();
            this.checkÜFensterTimer = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.switchÜFenster = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelÜFensterSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkAufnahmeOrdnerÖffnen);
            this.groupBox1.Controls.Add(this.lbOrdnerÖffnen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbAufnahmeordner);
            this.groupBox1.Controls.Add(this.bBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordnerüberwachung";
            // 
            // checkAufnahmeOrdnerÖffnen
            // 
            this.checkAufnahmeOrdnerÖffnen.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkAufnahmeOrdnerÖffnen.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkAufnahmeOrdnerÖffnen.Checked = true;
            this.checkAufnahmeOrdnerÖffnen.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkAufnahmeOrdnerÖffnen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAufnahmeOrdnerÖffnen.ForeColor = System.Drawing.Color.White;
            this.checkAufnahmeOrdnerÖffnen.Location = new System.Drawing.Point(127, 82);
            this.checkAufnahmeOrdnerÖffnen.Margin = new System.Windows.Forms.Padding(4);
            this.checkAufnahmeOrdnerÖffnen.Name = "checkAufnahmeOrdnerÖffnen";
            this.checkAufnahmeOrdnerÖffnen.Size = new System.Drawing.Size(20, 20);
            this.checkAufnahmeOrdnerÖffnen.TabIndex = 19;
            // 
            // lbOrdnerÖffnen
            // 
            this.lbOrdnerÖffnen.AutoSize = true;
            this.lbOrdnerÖffnen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdnerÖffnen.Location = new System.Drawing.Point(154, 82);
            this.lbOrdnerÖffnen.Name = "lbOrdnerÖffnen";
            this.lbOrdnerÖffnen.Size = new System.Drawing.Size(240, 17);
            this.lbOrdnerÖffnen.TabIndex = 6;
            this.lbOrdnerÖffnen.Text = "Aufnahmeordner nach Aufnahme öffnen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aufnahmeordner:";
            // 
            // tbAufnahmeordner
            // 
            this.tbAufnahmeordner.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbAufnahmeordner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAufnahmeordner.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAufnahmeordner.ForeColor = System.Drawing.Color.White;
            this.tbAufnahmeordner.Location = new System.Drawing.Point(127, 34);
            this.tbAufnahmeordner.Multiline = true;
            this.tbAufnahmeordner.Name = "tbAufnahmeordner";
            this.tbAufnahmeordner.ReadOnly = true;
            this.tbAufnahmeordner.Size = new System.Drawing.Size(486, 25);
            this.tbAufnahmeordner.TabIndex = 3;
            this.tbAufnahmeordner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbAufnahmeordner_MouseDown);
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.DodgerBlue;
            this.bBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.ForeColor = System.Drawing.Color.White;
            this.bBrowse.Location = new System.Drawing.Point(619, 34);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(30, 25);
            this.bBrowse.TabIndex = 4;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            this.bBrowse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bBrowse_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbFRam);
            this.groupBox2.Controls.Add(this.switchRAM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.switchCPU);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 63);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anzeige";
            // 
            // lbFRam
            // 
            this.lbFRam.AutoSize = true;
            this.lbFRam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFRam.Location = new System.Drawing.Point(119, 27);
            this.lbFRam.Name = "lbFRam";
            this.lbFRam.Size = new System.Drawing.Size(73, 17);
            this.lbFRam.TabIndex = 12;
            this.lbFRam.Text = "Freier RAM";
            // 
            // switchRAM
            // 
            this.switchRAM.BackColor = System.Drawing.Color.Transparent;
            this.switchRAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchRAM.BackgroundImage")));
            this.switchRAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchRAM.Location = new System.Drawing.Point(201, 24);
            this.switchRAM.Name = "switchRAM";
            this.switchRAM.OffColor = System.Drawing.Color.Gray;
            this.switchRAM.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchRAM.Size = new System.Drawing.Size(43, 25);
            this.switchRAM.TabIndex = 11;
            this.switchRAM.Value = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU";
            // 
            // switchCPU
            // 
            this.switchCPU.BackColor = System.Drawing.Color.Transparent;
            this.switchCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchCPU.BackgroundImage")));
            this.switchCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchCPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchCPU.Location = new System.Drawing.Point(54, 24);
            this.switchCPU.Name = "switchCPU";
            this.switchCPU.OffColor = System.Drawing.Color.Gray;
            this.switchCPU.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchCPU.Size = new System.Drawing.Size(43, 25);
            this.switchCPU.TabIndex = 9;
            this.switchCPU.Value = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelÜFensterSettings);
            this.groupBox3.Controls.Add(this.switchÜFenster);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 109);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Überwachungsfenster";
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
            // Überwachung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Überwachung";
            this.Text = "OrdnerüberwachungTab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelÜFensterSettings.ResumeLayout(false);
            this.panelÜFensterSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAufnahmeordner;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbFRam;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchRAM;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchCPU;
        private Ookii.Dialogs.VistaFolderBrowserDialog fbdAufnahmeordner;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbOrdnerÖffnen;
        private Bunifu.Framework.UI.BunifuCheckbox checkAufnahmeOrdnerÖffnen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelÜFensterSettings;
        private Bunifu.Framework.UI.BunifuCheckbox checkÜFensterRAM;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox checkÜFensterCPU;
        private System.Windows.Forms.Label lbCPU;
        private Bunifu.Framework.UI.BunifuCheckbox checkÜFensterTimer;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchÜFenster;
        private System.Windows.Forms.Label label6;
    }
}
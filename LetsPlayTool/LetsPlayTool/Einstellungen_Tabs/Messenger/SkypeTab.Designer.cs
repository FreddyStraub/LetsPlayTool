﻿namespace LetsPlayTool.Einstellungen_Tabs.Messenger
{
    partial class SkypeTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkypeTab));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.checkStatusMeldung = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbStatusMeldung = new System.Windows.Forms.Label();
            this.tbStatusmeldung = new System.Windows.Forms.RichTextBox();
            this.cbStatusNA = new Bunifu.Framework.UI.BunifuDropdown();
            this.lSNA = new System.Windows.Forms.Label();
            this.lbSIA = new System.Windows.Forms.Label();
            this.cbStatusIA = new Bunifu.Framework.UI.BunifuDropdown();
            this.lbAktivieren = new System.Windows.Forms.Label();
            this.switchActive = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.checkStatusMeldung);
            this.bunifuCards1.Controls.Add(this.lbStatusMeldung);
            this.bunifuCards1.Controls.Add(this.tbStatusmeldung);
            this.bunifuCards1.Controls.Add(this.cbStatusNA);
            this.bunifuCards1.Controls.Add(this.lSNA);
            this.bunifuCards1.Controls.Add(this.lbSIA);
            this.bunifuCards1.Controls.Add(this.cbStatusIA);
            this.bunifuCards1.Controls.Add(this.lbAktivieren);
            this.bunifuCards1.Controls.Add(this.switchActive);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.ForeColor = System.Drawing.Color.White;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 0;
            this.bunifuCards1.Size = new System.Drawing.Size(658, 252);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(658, 28);
            this.bunifuSeparator1.TabIndex = 40;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // checkStatusMeldung
            // 
            this.checkStatusMeldung.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkStatusMeldung.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkStatusMeldung.Checked = true;
            this.checkStatusMeldung.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.checkStatusMeldung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStatusMeldung.ForeColor = System.Drawing.Color.White;
            this.checkStatusMeldung.Location = new System.Drawing.Point(22, 120);
            this.checkStatusMeldung.Margin = new System.Windows.Forms.Padding(4);
            this.checkStatusMeldung.Name = "checkStatusMeldung";
            this.checkStatusMeldung.Size = new System.Drawing.Size(20, 20);
            this.checkStatusMeldung.TabIndex = 39;
            this.checkStatusMeldung.OnChange += new System.EventHandler(this.checkStatusMeldung_OnChange);
            // 
            // lbStatusMeldung
            // 
            this.lbStatusMeldung.AutoSize = true;
            this.lbStatusMeldung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusMeldung.Location = new System.Drawing.Point(49, 120);
            this.lbStatusMeldung.Name = "lbStatusMeldung";
            this.lbStatusMeldung.Size = new System.Drawing.Size(97, 17);
            this.lbStatusMeldung.TabIndex = 38;
            this.lbStatusMeldung.Text = "Statusmeldung:";
            this.toolTip1.SetToolTip(this.lbStatusMeldung, "Erzählen Siw was Sie gerade machen");
            // 
            // tbStatusmeldung
            // 
            this.tbStatusmeldung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tbStatusmeldung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatusmeldung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusmeldung.ForeColor = System.Drawing.Color.White;
            this.tbStatusmeldung.Location = new System.Drawing.Point(22, 147);
            this.tbStatusmeldung.Name = "tbStatusmeldung";
            this.tbStatusmeldung.Size = new System.Drawing.Size(623, 93);
            this.tbStatusmeldung.TabIndex = 37;
            this.tbStatusmeldung.Text = "";
            // 
            // cbStatusNA
            // 
            this.cbStatusNA.BackColor = System.Drawing.Color.Transparent;
            this.cbStatusNA.BorderRadius = 3;
            this.cbStatusNA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusNA.ForeColor = System.Drawing.Color.White;
            this.cbStatusNA.Items = new string[] {
        "Online",
        "Abwesend",
        "Beschäftigt",
        "Als offline anzeigen",
        "Offline"};
            this.cbStatusNA.Location = new System.Drawing.Point(475, 82);
            this.cbStatusNA.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatusNA.Name = "cbStatusNA";
            this.cbStatusNA.NomalColor = System.Drawing.Color.DodgerBlue;
            this.cbStatusNA.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.cbStatusNA.selectedIndex = -1;
            this.cbStatusNA.Size = new System.Drawing.Size(174, 26);
            this.cbStatusNA.TabIndex = 36;
            // 
            // lSNA
            // 
            this.lSNA.AutoSize = true;
            this.lSNA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSNA.Location = new System.Drawing.Point(329, 85);
            this.lSNA.Name = "lSNA";
            this.lSNA.Size = new System.Drawing.Size(139, 17);
            this.lSNA.TabIndex = 35;
            this.lSNA.Text = "Status nach Aufnahme:";
            // 
            // lbSIA
            // 
            this.lbSIA.AutoSize = true;
            this.lbSIA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSIA.Location = new System.Drawing.Point(12, 85);
            this.lbSIA.Name = "lbSIA";
            this.lbSIA.Size = new System.Drawing.Size(122, 17);
            this.lbSIA.TabIndex = 34;
            this.lbSIA.Text = "Status in Aufnahme:";
            // 
            // cbStatusIA
            // 
            this.cbStatusIA.BackColor = System.Drawing.Color.Transparent;
            this.cbStatusIA.BorderRadius = 3;
            this.cbStatusIA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusIA.ForeColor = System.Drawing.Color.White;
            this.cbStatusIA.Items = new string[] {
        "Online",
        "Abwesend",
        "Beschäftigt",
        "Als offline anzeigen",
        "Offline"};
            this.cbStatusIA.Location = new System.Drawing.Point(141, 82);
            this.cbStatusIA.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatusIA.Name = "cbStatusIA";
            this.cbStatusIA.NomalColor = System.Drawing.Color.DodgerBlue;
            this.cbStatusIA.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.cbStatusIA.selectedIndex = -1;
            this.cbStatusIA.Size = new System.Drawing.Size(174, 26);
            this.cbStatusIA.TabIndex = 33;
            // 
            // lbAktivieren
            // 
            this.lbAktivieren.AutoSize = true;
            this.lbAktivieren.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAktivieren.Location = new System.Drawing.Point(71, 27);
            this.lbAktivieren.Name = "lbAktivieren";
            this.lbAktivieren.Size = new System.Drawing.Size(64, 17);
            this.lbAktivieren.TabIndex = 32;
            this.lbAktivieren.Text = "Aktivieren";
            // 
            // switchActive
            // 
            this.switchActive.BackColor = System.Drawing.Color.Transparent;
            this.switchActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchActive.BackgroundImage")));
            this.switchActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchActive.Location = new System.Drawing.Point(22, 23);
            this.switchActive.Name = "switchActive";
            this.switchActive.OffColor = System.Drawing.Color.Gray;
            this.switchActive.OnColor = System.Drawing.Color.DodgerBlue;
            this.switchActive.Size = new System.Drawing.Size(43, 25);
            this.switchActive.TabIndex = 31;
            this.switchActive.Value = true;
            // 
            // SkypeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(658, 252);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SkypeTab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skype";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.RichTextBox tbStatusmeldung;
        private Bunifu.Framework.UI.BunifuDropdown cbStatusNA;
        private System.Windows.Forms.Label lSNA;
        private System.Windows.Forms.Label lbSIA;
        private Bunifu.Framework.UI.BunifuDropdown cbStatusIA;
        private System.Windows.Forms.Label lbAktivieren;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchActive;
        private System.Windows.Forms.Label lbStatusMeldung;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCheckbox checkStatusMeldung;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
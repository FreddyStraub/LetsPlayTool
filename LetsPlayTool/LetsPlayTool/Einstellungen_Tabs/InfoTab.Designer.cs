using Bunifu.Framework.UI;

namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class InfoTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoTab));
            this.lbLabelVersion = new System.Windows.Forms.Label();
            this.gbLetsPlayTool = new System.Windows.Forms.GroupBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbLabelWebsite = new System.Windows.Forms.Label();
            this.lbWebsite = new System.Windows.Forms.LinkLabel();
            this.lbLabelEntwickler = new System.Windows.Forms.Label();
            this.lbEnwtickler = new System.Windows.Forms.LinkLabel();
            this.bSeaarchForUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gbLetsPlayTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLabelVersion
            // 
            this.lbLabelVersion.AutoSize = true;
            this.lbLabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelVersion.ForeColor = System.Drawing.Color.White;
            this.lbLabelVersion.Location = new System.Drawing.Point(17, 34);
            this.lbLabelVersion.Name = "lbLabelVersion";
            this.lbLabelVersion.Size = new System.Drawing.Size(62, 18);
            this.lbLabelVersion.TabIndex = 0;
            this.lbLabelVersion.Text = "Version:";
            // 
            // gbLetsPlayTool
            // 
            this.gbLetsPlayTool.Controls.Add(this.bSeaarchForUpdate);
            this.gbLetsPlayTool.Controls.Add(this.lbEnwtickler);
            this.gbLetsPlayTool.Controls.Add(this.lbLabelEntwickler);
            this.gbLetsPlayTool.Controls.Add(this.lbWebsite);
            this.gbLetsPlayTool.Controls.Add(this.lbLabelWebsite);
            this.gbLetsPlayTool.Controls.Add(this.lbVersion);
            this.gbLetsPlayTool.Controls.Add(this.lbLabelVersion);
            this.gbLetsPlayTool.ForeColor = System.Drawing.Color.White;
            this.gbLetsPlayTool.Location = new System.Drawing.Point(12, 12);
            this.gbLetsPlayTool.Name = "gbLetsPlayTool";
            this.gbLetsPlayTool.Size = new System.Drawing.Size(671, 529);
            this.gbLetsPlayTool.TabIndex = 1;
            this.gbLetsPlayTool.TabStop = false;
            this.gbLetsPlayTool.Text = "LetsPlayTool";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbVersion.Location = new System.Drawing.Point(84, 35);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(52, 18);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "0.0.0.1";
            // 
            // lbLabelWebsite
            // 
            this.lbLabelWebsite.AutoSize = true;
            this.lbLabelWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelWebsite.ForeColor = System.Drawing.Color.White;
            this.lbLabelWebsite.Location = new System.Drawing.Point(17, 68);
            this.lbLabelWebsite.Name = "lbLabelWebsite";
            this.lbLabelWebsite.Size = new System.Drawing.Size(66, 18);
            this.lbLabelWebsite.TabIndex = 2;
            this.lbLabelWebsite.Text = "Website:";
            // 
            // lbWebsite
            // 
            this.lbWebsite.AutoSize = true;
            this.lbWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWebsite.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbWebsite.Location = new System.Drawing.Point(84, 68);
            this.lbWebsite.Name = "lbWebsite";
            this.lbWebsite.Size = new System.Drawing.Size(273, 18);
            this.lbWebsite.TabIndex = 4;
            this.lbWebsite.TabStop = true;
            this.lbWebsite.Text = "http://www.wolf066lp.de/letsplaytool.html";
            this.lbWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbWebsite_LinkClicked);
            // 
            // lbLabelEntwickler
            // 
            this.lbLabelEntwickler.AutoSize = true;
            this.lbLabelEntwickler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelEntwickler.ForeColor = System.Drawing.Color.White;
            this.lbLabelEntwickler.Location = new System.Drawing.Point(17, 103);
            this.lbLabelEntwickler.Name = "lbLabelEntwickler";
            this.lbLabelEntwickler.Size = new System.Drawing.Size(80, 18);
            this.lbLabelEntwickler.TabIndex = 5;
            this.lbLabelEntwickler.Text = "Entwickler:";
            // 
            // lbEnwtickler
            // 
            this.lbEnwtickler.AutoSize = true;
            this.lbEnwtickler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnwtickler.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lbEnwtickler.Location = new System.Drawing.Point(103, 103);
            this.lbEnwtickler.Name = "lbEnwtickler";
            this.lbEnwtickler.Size = new System.Drawing.Size(81, 18);
            this.lbEnwtickler.TabIndex = 6;
            this.lbEnwtickler.TabStop = true;
            this.lbEnwtickler.Text = "Wolf066LP";
            this.lbEnwtickler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbEnwtickler_LinkClicked);
            // 
            // bSeaarchForUpdate
            // 
            this.bSeaarchForUpdate.Activecolor = System.Drawing.Color.Green;
            this.bSeaarchForUpdate.BackColor = System.Drawing.Color.Green;
            this.bSeaarchForUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSeaarchForUpdate.BorderRadius = 0;
            this.bSeaarchForUpdate.ButtonText = "Nach Updates suchen";
            this.bSeaarchForUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSeaarchForUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.bSeaarchForUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.bSeaarchForUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("bSeaarchForUpdate.Iconimage")));
            this.bSeaarchForUpdate.Iconimage_right = null;
            this.bSeaarchForUpdate.Iconimage_right_Selected = null;
            this.bSeaarchForUpdate.Iconimage_Selected = null;
            this.bSeaarchForUpdate.IconRightVisible = true;
            this.bSeaarchForUpdate.IconRightZoom = 0D;
            this.bSeaarchForUpdate.IconVisible = true;
            this.bSeaarchForUpdate.IconZoom = 80D;
            this.bSeaarchForUpdate.IsTab = false;
            this.bSeaarchForUpdate.Location = new System.Drawing.Point(449, 466);
            this.bSeaarchForUpdate.Name = "bSeaarchForUpdate";
            this.bSeaarchForUpdate.Normalcolor = System.Drawing.Color.Green;
            this.bSeaarchForUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bSeaarchForUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.bSeaarchForUpdate.selected = false;
            this.bSeaarchForUpdate.Size = new System.Drawing.Size(207, 48);
            this.bSeaarchForUpdate.TabIndex = 7;
            this.bSeaarchForUpdate.Text = "Nach Updates suchen";
            this.bSeaarchForUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSeaarchForUpdate.Textcolor = System.Drawing.Color.White;
            this.bSeaarchForUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeaarchForUpdate.Click += new System.EventHandler(this.bSeaarchForUpdate_Click);
            // 
            // InfoTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.gbLetsPlayTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoTab";
            this.Text = "InfoTab";
            this.gbLetsPlayTool.ResumeLayout(false);
            this.gbLetsPlayTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLabelVersion;
        private System.Windows.Forms.GroupBox gbLetsPlayTool;
        private System.Windows.Forms.LinkLabel lbWebsite;
        private System.Windows.Forms.Label lbLabelWebsite;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.LinkLabel lbEnwtickler;
        private System.Windows.Forms.Label lbLabelEntwickler;
        private BunifuFlatButton bSeaarchForUpdate;
    }
}
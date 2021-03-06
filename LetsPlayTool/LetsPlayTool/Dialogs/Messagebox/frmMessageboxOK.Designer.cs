﻿namespace LetsPlayTool.Dialogs.Messagebox
{
    partial class frmMessageboxOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageboxOK));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.bClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bOK = new System.Windows.Forms.Button();
            this.Footer = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.Footer.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.lbTitle);
            this.HeaderBar.Controls.Add(this.bClose);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(402, 52);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(12, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(48, 25);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Title";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.TextChanged += new System.EventHandler(this.lbTitle_TextChanged);
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.bClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bClose.ErrorImage")));
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.ImageActive = null;
            this.bClose.Location = new System.Drawing.Point(355, 7);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(35, 35);
            this.bClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bClose.TabIndex = 2;
            this.bClose.TabStop = false;
            this.bClose.Zoom = 10;
            this.bClose.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bOK
            // 
            this.bOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.bOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.Color.White;
            this.bOK.Location = new System.Drawing.Point(269, 3);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(133, 44);
            this.bOK.TabIndex = 20;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = false;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.bOK);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 193);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(402, 50);
            this.Footer.TabIndex = 21;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.rtbText);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 52);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(18);
            this.MainPanel.Size = new System.Drawing.Size(402, 141);
            this.MainPanel.TabIndex = 23;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.ForeColor = System.Drawing.Color.White;
            this.rtbText.Location = new System.Drawing.Point(18, 18);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(366, 105);
            this.rtbText.TabIndex = 23;
            this.rtbText.Text = "";
            // 
            // frmMessageboxOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(402, 243);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageboxOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessagebox";
            this.Load += new System.EventHandler(this.frmMessagebox_Load);
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.Footer.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}
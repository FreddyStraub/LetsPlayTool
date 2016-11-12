namespace LetsPlayTool.Update
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUpdatePic = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbChangelog = new System.Windows.Forms.Label();
            this.bUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdatePic)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(388, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.label1);
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(435, 59);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eine neue Version ist verfügbar!";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // pbUpdatePic
            // 
            this.pbUpdatePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUpdatePic.Location = new System.Drawing.Point(0, 59);
            this.pbUpdatePic.Name = "pbUpdatePic";
            this.pbUpdatePic.Size = new System.Drawing.Size(435, 203);
            this.pbUpdatePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpdatePic.TabIndex = 2;
            this.pbUpdatePic.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(411, 184);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "-Neue Features!";
            // 
            // lbChangelog
            // 
            this.lbChangelog.AutoSize = true;
            this.lbChangelog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChangelog.ForeColor = System.Drawing.Color.White;
            this.lbChangelog.Location = new System.Drawing.Point(12, 277);
            this.lbChangelog.Name = "lbChangelog";
            this.lbChangelog.Size = new System.Drawing.Size(181, 25);
            this.lbChangelog.TabIndex = 4;
            this.lbChangelog.Text = "Changelog: Version ";
            // 
            // bUpdate
            // 
            this.bUpdate.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.bUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bUpdate.BorderRadius = 0;
            this.bUpdate.ButtonText = "Update";
            this.bUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.bUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.bUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("bUpdate.Iconimage")));
            this.bUpdate.Iconimage_right = null;
            this.bUpdate.Iconimage_right_Selected = null;
            this.bUpdate.Iconimage_Selected = null;
            this.bUpdate.IconRightVisible = true;
            this.bUpdate.IconRightZoom = 0D;
            this.bUpdate.IconVisible = true;
            this.bUpdate.IconZoom = 80D;
            this.bUpdate.IsTab = false;
            this.bUpdate.Location = new System.Drawing.Point(165, 508);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.bUpdate.selected = false;
            this.bUpdate.Size = new System.Drawing.Size(126, 48);
            this.bUpdate.TabIndex = 5;
            this.bUpdate.Text = "Update";
            this.bUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUpdate.Textcolor = System.Drawing.Color.White;
            this.bUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bCancel
            // 
            this.bCancel.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.BorderRadius = 0;
            this.bCancel.ButtonText = "Abbrechen";
            this.bCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancel.DisabledColor = System.Drawing.Color.Gray;
            this.bCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.bCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("bCancel.Iconimage")));
            this.bCancel.Iconimage_right = null;
            this.bCancel.Iconimage_right_Selected = null;
            this.bCancel.Iconimage_Selected = null;
            this.bCancel.IconRightVisible = true;
            this.bCancel.IconRightZoom = 0D;
            this.bCancel.IconVisible = true;
            this.bCancel.IconZoom = 80D;
            this.bCancel.IsTab = false;
            this.bCancel.Location = new System.Drawing.Point(297, 508);
            this.bCancel.Name = "bCancel";
            this.bCancel.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.bCancel.selected = false;
            this.bCancel.Size = new System.Drawing.Size(126, 48);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Abbrechen";
            this.bCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCancel.Textcolor = System.Drawing.Color.White;
            this.bCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbVersion.Location = new System.Drawing.Point(184, 278);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(64, 25);
            this.lbVersion.TabIndex = 7;
            this.lbVersion.Text = "0.0.0.1";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(435, 568);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.lbChangelog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pbUpdatePic);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.HeaderBar.ResumeLayout(false);
            this.HeaderBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpdatePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel HeaderBar;
        private System.Windows.Forms.PictureBox pbUpdatePic;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbChangelog;
        private Bunifu.Framework.UI.BunifuFlatButton bUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVersion;
    }
}
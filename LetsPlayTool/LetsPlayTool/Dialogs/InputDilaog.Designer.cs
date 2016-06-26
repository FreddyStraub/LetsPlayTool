namespace LetsPlayTool.Dialogs
{
    partial class InputDilaog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDilaog));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbString = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.bFertig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bAbbrechen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBar
            // 
            this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.HeaderBar.Controls.Add(this.bunifuImageButton1);
            this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBar.Location = new System.Drawing.Point(0, 0);
            this.HeaderBar.Name = "HeaderBar";
            this.HeaderBar.Size = new System.Drawing.Size(563, 52);
            this.HeaderBar.TabIndex = 0;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(520, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // tbString
            // 
            this.tbString.BackColor = System.Drawing.Color.DodgerBlue;
            this.tbString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbString.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbString.ForeColor = System.Drawing.Color.White;
            this.tbString.Location = new System.Drawing.Point(65, 65);
            this.tbString.Multiline = true;
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(486, 25);
            this.tbString.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(12, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 16);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bFertig.Location = new System.Drawing.Point(321, 104);
            this.bFertig.Name = "bFertig";
            this.bFertig.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bFertig.OnHovercolor = System.Drawing.Color.LimeGreen;
            this.bFertig.OnHoverTextColor = System.Drawing.Color.White;
            this.bFertig.selected = false;
            this.bFertig.Size = new System.Drawing.Size(116, 32);
            this.bFertig.TabIndex = 11;
            this.bFertig.Textcolor = System.Drawing.Color.White;
            this.bFertig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFertig.Click += new System.EventHandler(this.bFertig_Click);
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAbbrechen.BorderRadius = 0;
            this.bAbbrechen.ButtonText = "Abbrechen";
            this.bAbbrechen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAbbrechen.Iconcolor = System.Drawing.Color.Transparent;
            this.bAbbrechen.Iconimage = ((System.Drawing.Image)(resources.GetObject("bAbbrechen.Iconimage")));
            this.bAbbrechen.Iconimage_right = null;
            this.bAbbrechen.Iconimage_right_Selected = null;
            this.bAbbrechen.Iconimage_Selected = null;
            this.bAbbrechen.IsTab = false;
            this.bAbbrechen.Location = new System.Drawing.Point(439, 104);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.bAbbrechen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAbbrechen.OnHoverTextColor = System.Drawing.Color.White;
            this.bAbbrechen.selected = false;
            this.bAbbrechen.Size = new System.Drawing.Size(116, 32);
            this.bAbbrechen.TabIndex = 12;
            this.bAbbrechen.Textcolor = System.Drawing.Color.White;
            this.bAbbrechen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAbbrechen.Click += new System.EventHandler(this.bAbbrechen_Click);
            // 
            // InputDilaog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(563, 149);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bFertig);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputDilaog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputDilaog";
            this.HeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Label lbName;
        private Bunifu.Framework.UI.BunifuFlatButton bFertig;
        private Bunifu.Framework.UI.BunifuFlatButton bAbbrechen;
    }
}
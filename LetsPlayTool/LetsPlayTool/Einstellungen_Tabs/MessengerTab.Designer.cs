namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class MessengerTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessengerTab));
            this.bcSkype = new Bunifu.Framework.UI.BunifuCards();
            this.bSkype = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bSkype)).BeginInit();
            this.SuspendLayout();
            // 
            // bcSkype
            // 
            this.bcSkype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bcSkype.BorderRadius = 5;
            this.bcSkype.BottomSahddow = true;
            this.bcSkype.color = System.Drawing.Color.DodgerBlue;
            this.bcSkype.LeftSahddow = false;
            this.bcSkype.Location = new System.Drawing.Point(0, 98);
            this.bcSkype.Name = "bcSkype";
            this.bcSkype.RightSahddow = false;
            this.bcSkype.ShadowDepth = 0;
            this.bcSkype.Size = new System.Drawing.Size(695, 453);
            this.bcSkype.TabIndex = 0;
            // 
            // bSkype
            // 
            this.bSkype.BackColor = System.Drawing.Color.DodgerBlue;
            this.bSkype.Image = ((System.Drawing.Image)(resources.GetObject("bSkype.Image")));
            this.bSkype.ImageActive = null;
            this.bSkype.Location = new System.Drawing.Point(12, 22);
            this.bSkype.Name = "bSkype";
            this.bSkype.Size = new System.Drawing.Size(60, 60);
            this.bSkype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bSkype.TabIndex = 1;
            this.bSkype.TabStop = false;
            this.bSkype.Zoom = 5;
            this.bSkype.Click += new System.EventHandler(this.bSkype_Click);
            // 
            // MessengerTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.bSkype);
            this.Controls.Add(this.bcSkype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessengerTab";
            this.Text = "MessengerTab";
            this.Load += new System.EventHandler(this.MessengerTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSkype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bcSkype;
        private Bunifu.Framework.UI.BunifuImageButton bSkype;
    }
}
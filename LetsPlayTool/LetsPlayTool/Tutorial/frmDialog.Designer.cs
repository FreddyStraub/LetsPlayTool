namespace LetsPlayTool.Tutorial
{
    partial class frmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDialog));
            this.HeaderBar = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bTutorial = new Bunifu.Framework.UI.BunifuTileButton();
            this.bTool = new Bunifu.Framework.UI.BunifuTileButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.HeaderBar.Size = new System.Drawing.Size(298, 59);
            this.HeaderBar.TabIndex = 1;
            this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
            this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(248, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bTutorial
            // 
            this.bTutorial.BackColor = System.Drawing.Color.DodgerBlue;
            this.bTutorial.color = System.Drawing.Color.DodgerBlue;
            this.bTutorial.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTutorial.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTutorial.ForeColor = System.Drawing.Color.White;
            this.bTutorial.Image = ((System.Drawing.Image)(resources.GetObject("bTutorial.Image")));
            this.bTutorial.ImagePosition = 25;
            this.bTutorial.ImageZoom = 50;
            this.bTutorial.LabelPosition = 35;
            this.bTutorial.LabelText = "Tutorial";
            this.bTutorial.Location = new System.Drawing.Point(15, 70);
            this.bTutorial.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bTutorial.Name = "bTutorial";
            this.bTutorial.Size = new System.Drawing.Size(128, 125);
            this.bTutorial.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bTutorial, "Kurzanleitung zur Benutzung des Tool");
            this.bTutorial.Click += new System.EventHandler(this.bTutorial_Click);
            // 
            // bTool
            // 
            this.bTool.BackColor = System.Drawing.Color.DodgerBlue;
            this.bTool.color = System.Drawing.Color.DodgerBlue;
            this.bTool.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTool.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTool.ForeColor = System.Drawing.Color.White;
            this.bTool.Image = ((System.Drawing.Image)(resources.GetObject("bTool.Image")));
            this.bTool.ImagePosition = 25;
            this.bTool.ImageZoom = 50;
            this.bTool.LabelPosition = 35;
            this.bTool.LabelText = "Tool";
            this.bTool.Location = new System.Drawing.Point(155, 70);
            this.bTool.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bTool.Name = "bTool";
            this.bTool.Size = new System.Drawing.Size(128, 125);
            this.bTool.TabIndex = 3;
            this.toolTip1.SetToolTip(this.bTool, "Ohne Anleitung fortfahren");
            this.bTool.Click += new System.EventHandler(this.bTool_Click);
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(298, 212);
            this.Controls.Add(this.bTool);
            this.Controls.Add(this.bTutorial);
            this.Controls.Add(this.HeaderBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialog";
            this.HeaderBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderBar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuTileButton bTutorial;
        private Bunifu.Framework.UI.BunifuTileButton bTool;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
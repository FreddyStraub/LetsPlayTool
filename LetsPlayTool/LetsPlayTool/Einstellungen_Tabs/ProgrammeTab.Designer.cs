namespace LetsPlayTool.Einstellungen_Tabs
{
    partial class ProgrammeTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgrammeTab));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bHinzufügen = new Bunifu.Framework.UI.BunifuTileButton();
            this.bEntfernen = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(385, 480);
            this.listBox1.TabIndex = 0;
            // 
            // bHinzufügen
            // 
            this.bHinzufügen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bHinzufügen.color = System.Drawing.Color.DodgerBlue;
            this.bHinzufügen.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bHinzufügen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHinzufügen.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bHinzufügen.ForeColor = System.Drawing.Color.White;
            this.bHinzufügen.Image = ((System.Drawing.Image)(resources.GetObject("bHinzufügen.Image")));
            this.bHinzufügen.ImagePosition = 20;
            this.bHinzufügen.ImageZoom = 50;
            this.bHinzufügen.LabelPosition = 41;
            this.bHinzufügen.LabelText = "Hinzufügen";
            this.bHinzufügen.Location = new System.Drawing.Point(406, 52);
            this.bHinzufügen.Margin = new System.Windows.Forms.Padding(6);
            this.bHinzufügen.Name = "bHinzufügen";
            this.bHinzufügen.Size = new System.Drawing.Size(128, 129);
            this.bHinzufügen.TabIndex = 1;
            // 
            // bEntfernen
            // 
            this.bEntfernen.BackColor = System.Drawing.Color.DodgerBlue;
            this.bEntfernen.color = System.Drawing.Color.DodgerBlue;
            this.bEntfernen.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(223)))));
            this.bEntfernen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEntfernen.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bEntfernen.ForeColor = System.Drawing.Color.White;
            this.bEntfernen.Image = ((System.Drawing.Image)(resources.GetObject("bEntfernen.Image")));
            this.bEntfernen.ImagePosition = 20;
            this.bEntfernen.ImageZoom = 50;
            this.bEntfernen.LabelPosition = 41;
            this.bEntfernen.LabelText = "Entfernen";
            this.bEntfernen.Location = new System.Drawing.Point(406, 193);
            this.bEntfernen.Margin = new System.Windows.Forms.Padding(6);
            this.bEntfernen.Name = "bEntfernen";
            this.bEntfernen.Size = new System.Drawing.Size(128, 129);
            this.bEntfernen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programme die durch einen einfachen Klick gestartet werden können.";
            // 
            // ProgrammeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(695, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bEntfernen);
            this.Controls.Add(this.bHinzufügen);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgrammeTab";
            this.Text = "ProgrammeTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuTileButton bHinzufügen;
        private Bunifu.Framework.UI.BunifuTileButton bEntfernen;
        private System.Windows.Forms.Label label1;
    }
}
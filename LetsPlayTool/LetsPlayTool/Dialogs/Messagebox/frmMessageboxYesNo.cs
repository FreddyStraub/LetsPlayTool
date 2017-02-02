using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Dialogs.Messagebox
{
    public partial class frmMessageboxYesNo : Form
    {

        public string Title { get; set; }

        public frmMessageboxYesNo(string Text, string Title)
        {
            InitializeComponent();

            this.Title = Title;
            this.Text = Text;
        }

        #region Move Form

        private Point mouseposition;

        private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseposition.X, mouseposition.Y);
                Location = mousePos;
            }
        }

        private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposition = new Point(-e.X, -e.Y);
        }



        #endregion

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMessageboxYesNo_Load(object sender, EventArgs e)
        {
            rtbText.Text = Text;
            lbTitle.Text = Title;
        }

        private void bJa_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

        }

        private void bNein_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

        }

        private void lbTitle_TextChanged(object sender, EventArgs e)
        {
            if (Title.Length > 35)
            {

                Title = Title.Substring(0, 32) + "...";
                lbTitle.Text = Title;
            }

        }
    }
}

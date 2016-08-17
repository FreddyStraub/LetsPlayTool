using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    public partial class frmÜFenster : Form
    {
        public frmÜFenster()
        {
            InitializeComponent();
        }

        Einstellungen einstellungen = new Einstellungen();

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
        

        private void frmÜFenster_Activated(object sender, EventArgs e)
        {

            einstellungen = einstellungen.load();

            lbTimer.Text = Text;
            TopMost = true;
            

        }

        private void frmÜFenster_TextChanged(object sender, EventArgs e)
        {

            lbTimer.Text = Text;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    }


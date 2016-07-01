using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Dialogs
{
    public partial class InputDilaog : Form
    {
        public InputDilaog()
        {
            InitializeComponent();
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

        public string Input { get; private set; }

        private void bFertig_Click(object sender, EventArgs e)
        {
            Input = tbString.Text;

            this.DialogResult = DialogResult.OK;

        }

        private void bAbbrechen_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void InputDilaog_KeyDown(object sender, KeyEventArgs e)
        {

            //Bestätogen (Enter)
            if(e.KeyCode == Keys.Enter)
            {
                Input = tbString.Text;

                this.DialogResult = DialogResult.OK;


            }

            //Abbrechen 
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;

            }

        }
    }
}

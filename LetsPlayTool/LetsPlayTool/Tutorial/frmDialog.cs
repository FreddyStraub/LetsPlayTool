using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Tutorial
{
    public partial class frmDialog : Form
    {
        public frmDialog()
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


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bTool_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bTutorial_Click(object sender, EventArgs e)
        {

            string pfad = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool\\Tutorials\\";

            #region Herzlich Willkommen

            TutorialClasses.Tutorial t = new TutorialClasses.Tutorial();


            t = t.load(pfad  + "\\Herzlich Willkommen.tut");

            Tutorial.frmTutorials frmt = new Tutorial.frmTutorials(t);
            frmt.ShowDialog();

            #endregion

            #region Übersicht

             t = new TutorialClasses.Tutorial();

            t = t.load(pfad + "\\Übersicht.tut");

            frmt = new Tutorial.frmTutorials(t);
            frmt.ShowDialog();

            #endregion

            #region Einstellungen

            t = new TutorialClasses.Tutorial();

            t = t.load(pfad + "\\Einstellungen.tut");

            frmt = new Tutorial.frmTutorials(t);
            frmt.ShowDialog();

            #endregion

            Close();

        }
    }
}

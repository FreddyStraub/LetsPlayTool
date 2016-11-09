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


            #region Design

            //CPU
            if(einstellungen.Allgemeines.ShowÜFensterCPU == true)
            {

                lbCPU.Visible = true;
                lbCPUAuslastung.Visible = true;

            }else
            {
                lbCPU.Visible = false;
                lbCPUAuslastung.Visible = false;
                
            }

            //RAM
            if (einstellungen.Allgemeines.ShowÜFensterRAM == true)
            {

                lbRAM.Visible = true;
                lbRAMUsed.Visible = true;

            }
            else
            {
                lbRAM.Visible = false;
                lbRAMUsed.Visible = false;

            }


            //TIMER
            if (einstellungen.Allgemeines.ShowÜFensterTimer == true)
            {

                lbTimer.Visible = true;

            }
            else
            {
                lbTimer.Visible = false;

            }

            #endregion
        }

        private void frmÜFenster_TextChanged(object sender, EventArgs e)
        {

            lbTimer.Text = Text;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Zeigt eine Nachricht auf dem ÜFenster an.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <param name="duration"></param>
        public void showMessage(string message, Color color, int duration)
        {
    
                LetsPlayToolMessage.ÜFenster S = new LetsPlayToolMessage.ÜFenster(message, duration, color);

                S.TopLevel = false;
                S.AutoScroll = true;

                Controls.Add(S);

                S.Location = new Point(0, 59);

                S.BringToFront();

                S.Show();
                S.ShowMessage.Start();

         
        
        }

        private void lbTimer_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms[0];

            if (!frmMain.SessionRuns)
            {
                frmMain.startSession();
                frmMain.SessionRuns = true;

            }
            else
            {
                frmMain.stopSession();
                frmMain.SessionRuns = false;
            }


        }

        private void frmÜFenster_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms[0];
            frmMain.ÜFensterLocation = Location;

        }
    }


    }


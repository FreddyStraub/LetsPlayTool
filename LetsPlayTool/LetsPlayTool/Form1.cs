using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    public partial class Form1 : Form
    {

        Einstellungen einstellungen = new Einstellungen();

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            MinimaizeAnimation.Start();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            MaximaizeAnimation.Start();
            einstellungen = einstellungen.load();

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
        
        #region general Animations

        /// <summary>
        /// Minimaize Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimaizeAnimation_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity - 0.1;

            if (Opacity == 0)
            {
                MinimaizeAnimation.Stop();
                WindowState = FormWindowState.Minimized;

            }
        }

        /// <summary>
        /// Maximaize Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximaizeAnimation_Tick(object sender, EventArgs e)
        {


            WindowState = FormWindowState.Normal;


            if (Opacity == 1)
            {
                MaximaizeAnimation.Stop();

            }
            else
            {
                Opacity = Opacity + 0.1;

            }

        }



        #endregion


        int slide = 0;
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            ShowPanelsAnimation.Start();

        }
        
        private void ShowPanelsAnimation_Tick(object sender, EventArgs e)
        {

            ShowPanelsAnimation.Stop();
            switch (slide)
            {

                case 0:

                    ShowPanelAnimator.Show(panelTimer);
                    panelTimer.BringToFront();

                    break;
                case 1:

                    ShowPanelAnimator.Show(panelOrdner);
                    panelOrdner.BringToFront();

                    break;

                case 2:
                    ShowPanelAnimator.Show(panelMarker);
                    panelMarker.BringToFront();

                    break;
                case 3:
                    ShowPanelAnimator.Show(panelÜberwachung);
                    panelÜberwachung.BringToFront();

                    break;
                case 4:
                    ShowPanelAnimator.Show(panelSoundÜberwachung);
                    panelSoundÜberwachung.BringToFront();

                    break;
            }

            if (slide < 4)
            {
                slide++;
                ShowPanelsAnimation.Start();
            }
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            frmEinstellungen frmEinstellungen = new frmEinstellungen();
            frmEinstellungen.ShowDialog();

            einstellungen = einstellungen.load();
        }


        public int Stunden { get; set; }
        public int Minuten { get; set; }
        public int Sekunden { get; set; }
        public int Millisekunden { get; set; }

        Stopwatch Timerwatch = new Stopwatch();

             
        private void Mainactor_Tick(object sender, EventArgs e)
        {

            #region Timer

            #region Time
            string TimeString = "";
            
            Millisekunden += 1;

            if (Millisekunden == 65)
            {
                Sekunden += 1;
                Millisekunden = 0;
            }

            if (Sekunden == 60)
            {
                Minuten += 1;
                Sekunden = 0;
            }

            if (Minuten == 60)
            {
                Stunden += 1;
                Minuten = 0;
            }

            TimeString = Stunden + ":" + Minuten + ":" + Sekunden + ":" + Millisekunden;

            bunifuCustomLabel1.Text = TimeString;
            #endregion

            #region Message



            #endregion

            #endregion
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

            startSession();

        }

        private void bOpenPrograms_Click(object sender, EventArgs e)
        {
            selectTimerProifil();

        }

        /// <summary>
        /// Zeigt ein kleine Nachricht in dem Panel an.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="message"></param>
        private void showSmallMessage(Panel panel, string message)
        {

            LetsPlayToolMessage.Small S = new LetsPlayToolMessage.Small(message);

            S.TopLevel = false;
            S.AutoScroll = true;

            panel.Controls.Add(S);

            S.BringToFront();

            S.Show();
            S.ShowMessage.Start();


        }

        /// <summary>
        /// Startet die Session und alle Funktionen.
        /// </summary>
        private void startSession()
        {

            Mainactor.Start();

        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        /// <summary>
        /// Läst den User ein Timerprofil auswählen
        /// </summary>
        private void selectTimerProifil()
        {

            frmTimerprofilAuswahl TPA = new frmTimerprofilAuswahl(einstellungen);

 
                TPA.TopLevel = false;
                TPA.AutoScroll = true;

                Controls.Add(TPA);

                TPA.Show();

                TPA.Location = new Point(0, Location.Y + 10);

                TPA.BringToFront();
            
        }
    }
}

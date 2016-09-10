using LetsPlayTool.Dialogs;
using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
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

            loadSettings();

        }

        /// <summary>
        /// Lädt die Einstellungen und setzt sie.
        /// </summary>
        private void loadSettings()
        {
            try
            {
                einstellungen = einstellungen.load();
            }
            catch
            {

                Einstellungen st = new Einstellungen();
                st.SetStandartValues();
                st.save();

                einstellungen = einstellungen.load();

            }

            #region Überwachung

            selectedTimerProfil = einstellungen.Timer.SelectedTimerProfil;

            if (einstellungen.Überwachung.ÜberwachungOrdner.Length > 40)
            {
                int startIndex = einstellungen.Überwachung.ÜberwachungOrdner.Length - 40;
                lbPath.Text = "... " + einstellungen.Überwachung.ÜberwachungOrdner.Substring(startIndex);
            }
            else
            {
                lbPath.Text = einstellungen.Überwachung.ÜberwachungOrdner;

            }


            #region CPU

            if (einstellungen.Überwachung.ÜShowCPU == true)
            {

                lbCPU.Visible = true;
                lbCPUAuslastung.Visible = true;

            }else
            {
                lbCPU.Visible = false;
                lbCPUAuslastung.Visible = false;

            }

            #endregion
            #region RAM

            if (einstellungen.Überwachung.ÜShowRAM == true)
            {

                lbRAM.Visible = true;
                lbRAMUsed.Visible = true;

            }
            else
            {
                lbRAM.Visible = false;
                lbRAMUsed.Visible = false;

            }


            #endregion

            #endregion

            if (einstellungen.Allgemeines.ShowÜFenster == true)
            {

                bShowÜFenster.Visible = true;

            }else
            {
                bShowÜFenster.Visible = false;

            }

            #region Skype

            if (einstellungen.Überwachung.MessengerSettings.skypeSettings.active)
            {
                skype = new Skype();

                if(skype.Client.IsRunning)
                {

                    skype.Attach();
                    lbSkypeStatus.Text = "...";
                    lbSkypeStatus.ForeColor = Color.Lime;


                }
                else
                {

                    einstellungen.Überwachung.MessengerSettings.skypeSettings.active = false;

                    einstellungen.save();
                    einstellungen = einstellungen.load();

                    showSmallMessage(panelÜberwachung, "Es wurde kein Skype Client gefunden!", Color.Red);

                    lbSkypeStatus.Text = "Kein Skype Client gefunden";
                    lbSkypeStatus.ForeColor = Color.Red;

                    loadSettings();
                }

            }else
            {

                lbSkypeStatus.Text = "Deaktiviert";
                lbSkypeStatus.ForeColor = Color.Orange;

            }

            #endregion

            unregisterHotKeys();
            registerHotkeys();

            #region Timer

            selectedTimerProfil = einstellungen.Timer.SelectedTimerProfil;

            try

            {

                toolTip1.SetToolTip(labelTimer, selectedTimerProfil.name);

            }
            catch { }

            #endregion
        }


        Skype skype;



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
            frmEinstellungen.selectedTimerProfil = selectedTimerProfil;
            frmEinstellungen.ShowDialog();


            loadSettings();
        }

        Session.Session Session;


        public string NormalStatus = "";

        public static TimerProfil selectedTimerProfil;

        public bool SessionRuns = false;


        int MainactorElapsedTicks = 0;
        int cpuTimervalue = 0;

        Point ÜFensterLocation = new Point();

        private void Mainactor_Tick(object sender, EventArgs e)
        {

            Session.Next();

            ÜFensterLocation = frmÜFenster.Location;

            MainactorElapsedTicks++;

            #region Timer

            labelTimer.Text = Session.Timer.TimeString;
            frmÜFenster.Text = Session.Timer.TimeString;

            //Macht, das bei eingestellter Zeit die Nachricht angezeigt wird
            #region Message

            foreach (Time t in Session.Timer.getTimes())
            {


                #region 0 Time

                if (t.ListViewItem.Text == "00:00:00:00" && Session.Timer.TimeString == "00:00:00:01")
                    showSmallMessage(panelTimer, t.Text, t.ListViewItem.BackColor);


                #endregion

                if (t.ListViewItem.Text == Session.Timer.TimeString)
                {

                    if (t.Text != "")
                    {

                        showSmallMessage(panelTimer, t.Text, t.ListViewItem.BackColor); //wenn Text dann text anzeigen.
                        frmÜFenster.showMessage(t.Text, t.ListViewItem.BackColor, 3);

                    }
                    else
                    {

                        showSmallMessage(panelTimer, t.ListViewItem.Text, t.ListViewItem.BackColor); // wenn kein Text, dann Zeit anzeigen.
                        frmÜFenster.showMessage(t.ListViewItem.Text, t.ListViewItem.BackColor, 3);

                    }
                }



            }
            #endregion

            #endregion

            #region Überwachung

            #region Speicher

         
            //Ausgabe an User
            lbBSpeicherGB.Text = Session.Überwachung.belegterSpeicherGB.ToString() + "GB";
            lbFSpeicherGB.Text = Session.Überwachung.freierSpeicherGB.ToString() + "GB";

            toolTip1.SetToolTip(lbBSpeicherGB, Session.Überwachung.belegterSpeicherMB.ToString() + "MB");
            toolTip1.SetToolTip(lbFSpeicherGB, Session.Überwachung.freierSpeicherMB.ToString() + "MB");

            #endregion
            
            #region CPU & RAM


            if (MainactorElapsedTicks == cpuTimervalue + 100)
            {


                lbCPUAuslastung.Text = Session.Überwachung.cpuAuslastung.ToString() + "%"; //CPU-Auslastung in Prozent
                lbRAMUsed.Text = Session.Überwachung.freierRAM.ToString() + "MB"; //Verfügbarer RAM in Megabyte

                cpuTimervalue += 100;

                //ÜFenster
                frmÜFenster.lbCPUAuslastung.Text = lbCPUAuslastung.Text;
                frmÜFenster.lbRAMUsed.Text = lbRAMUsed.Text;


                #region Desgin
                

                //CPU
                if(Session.Überwachung.cpuAuslastung > 50 & Session.Überwachung.cpuAuslastung < 80)
                {
                    lbCPUAuslastung.BackColor = Color.Yellow;
                    frmÜFenster.lbCPUAuslastung.BackColor = Color.Yellow;

                }else if(Session.Überwachung.cpuAuslastung > 80)
                {
                    lbCPUAuslastung.BackColor = Color.Red;
                    frmÜFenster.lbCPUAuslastung.BackColor = Color.Red;
                }
                else
                {
                    lbCPUAuslastung.BackColor = Color.FromArgb(38,38,38);
                    frmÜFenster.lbCPUAuslastung.BackColor = Color.FromArgb(38, 38, 38);
                }

                //Freier RAM
                if (Session.Überwachung.freierRAM > 200 & Session.Überwachung.freierRAM < 800)
                {
                    lbRAMUsed.BackColor = Color.Yellow;
                    frmÜFenster.lbRAMUsed.BackColor = Color.Yellow;

                }
                else if (Session.Überwachung.freierRAM < 200)
                {
                    lbRAMUsed.BackColor = Color.Red;
                    frmÜFenster.lbRAMUsed.BackColor = Color.Red;
                }
                else
                {
                    lbRAMUsed.BackColor = Color.FromArgb(38, 38, 38);
                    frmÜFenster.lbRAMUsed.BackColor = Color.FromArgb(38, 38, 38);
                }
                #endregion

            }


            #endregion

            #region Messenger

            #region Display Status


            if (einstellungen.Überwachung.MessengerSettings.skypeSettings.active)
            {
                switch (skype.CurrentUserStatus)
                {

                    case TUserStatus.cusOnline: lbSkypeStatus.Text = "Online"; break;
                    case TUserStatus.cusAway: lbSkypeStatus.Text = "Abwesend"; break;
                    case TUserStatus.cusDoNotDisturb: lbSkypeStatus.Text = "Beschäftigt"; break;
                    case TUserStatus.cusInvisible: lbSkypeStatus.Text = "Als Offline anzeigen"; break;
                    case TUserStatus.cusOffline: lbSkypeStatus.Text = "Offline"; break;

                }
            }



            #endregion

            #endregion


            #endregion

        } //Mainactor!!!!!!!!!!!!!!!!!!

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

            if (!SessionRuns)
            {
                startSession();
                SessionRuns = true;

            }
            else
            {
                stopSession();
                SessionRuns = false;
            }


        }

        private void bOpenPrograms_Click(object sender, EventArgs e)
        {
            einstellungen.Programme.startProgramms();

        }

        #region showMessages

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
        /// Zeigt ein kleine Nachricht in dem Panel an.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="message"></param>
        private void showSmallMessage(Panel panel, string message, Color color)
        {

            LetsPlayToolMessage.Small S = new LetsPlayToolMessage.Small(message, color);

            S.TopLevel = false;
            S.AutoScroll = true;

            panel.Controls.Add(S);

            S.BringToFront();

            S.Show();
            S.ShowMessage.Start();


        }

        /// <summary>
        /// Zeigt eine große Nachricht auf dem ganzen Fenster an
        /// </summary>
        /// <param name="Message"></param>
        private void showBigMessage(string Message)
        {

            LetsPlayToolMessage.Big B = new LetsPlayToolMessage.Big(Message, einstellungen.Allgemeines.ErinerrungenAnzeigeDauer);

            B.TopLevel = false;
            B.AutoScroll = true;

            Controls.Add(B);

            B.Location = new Point(0, 59);
            B.BringToFront();

            B.Show();
            B.ShowMessage.Start();



        }

        #endregion

        frmÜFenster frmÜFenster = new frmÜFenster(); //Kleiner Überwachungsfenster

        /// <summary>
        /// Startet die Session und alle Funktionen.
        /// </summary>
        private void startSession()
        {
            Session = new LetsPlayTool.Session.Session(selectedTimerProfil, einstellungen);

            //InitialisierePerformanceCounter();

            Mainactor.Start();

            einstellungen.SessionValue += 1;

            listMarker.Items.Clear();

            if (einstellungen.Allgemeines.ShowÜFenster)
            {
                frmÜFenster.Close();
                frmÜFenster = new frmÜFenster();
                frmÜFenster.Show();

                frmÜFenster.Location = ÜFensterLocation;

            }

            if (einstellungen.Allgemeines.ShowIErinerrung)
            {
                showBigMessage(einstellungen.Allgemeines.Erinerrungen);
            }


            #region Get Times

            if (selectedTimerProfil == null)
            {
               
                stopSession();
                showSmallMessage(panelTimer, "Bitte wähle ein Timerprofil aus!", Color.Red);

            }
            #endregion

            #region Messenger

            #region Skype

            if (einstellungen.Überwachung.MessengerSettings.skypeSettings.active)
            {

                #region Status
                switch (einstellungen.Überwachung.MessengerSettings.skypeSettings.statusInAufnahme)
                {
                    case 0: skype.ChangeUserStatus(TUserStatus.cusOnline); break;
                    case 1: skype.ChangeUserStatus(TUserStatus.cusAway);  break;
                    case 2: skype.ChangeUserStatus(TUserStatus.cusDoNotDisturb); break;
                    case 3: skype.ChangeUserStatus(TUserStatus.cusInvisible); break;
                    case 4: skype.ChangeUserStatus(TUserStatus.cusOffline);  break;

                }

                #endregion

                if (einstellungen.Überwachung.MessengerSettings.skypeSettings.writeStatusmeldung)
                {

                    NormalStatus = skype.CurrentUserProfile.MoodText;
                    skype.CurrentUserProfile.MoodText = einstellungen.Überwachung.MessengerSettings.skypeSettings.Statusmeldung;

                }
            }

            #endregion

            #endregion


        }

        /// <summary>
        /// Stoppt die Session und alle Funktionen
        /// </summary>
        private void stopSession()
        {
            createMarkerFile();
            Mainactor.Stop();

            ÜFensterLocation = frmÜFenster.Location;

            #region Messenger

            #region Skype


            #region Status
            if (einstellungen.Überwachung.MessengerSettings.skypeSettings.active)
            {

                #region SetSkypeStatus

                switch (einstellungen.Überwachung.MessengerSettings.skypeSettings.statusNachAufnahme)
                {
                    case 0: skype.ChangeUserStatus(TUserStatus.cusOnline); break;
                    case 1: skype.ChangeUserStatus(TUserStatus.cusAway); break;
                    case 2: skype.ChangeUserStatus(TUserStatus.cusDoNotDisturb); break;
                    case 3: skype.ChangeUserStatus(TUserStatus.cusInvisible); break;
                    case 4: skype.ChangeUserStatus(TUserStatus.cusOffline); break;

                }

                #endregion

                #region SetLabelText

                switch (skype.CurrentUserStatus)
                {

                    case TUserStatus.cusOnline: lbSkypeStatus.Text = "Online"; break;
                    case TUserStatus.cusAway: lbSkypeStatus.Text = "Abwesend"; break;
                    case TUserStatus.cusDoNotDisturb: lbSkypeStatus.Text = "Beschäftigt"; break;
                    case TUserStatus.cusInvisible: lbSkypeStatus.Text = "Als Offline anzeigen"; break;
                    case TUserStatus.cusOffline: lbSkypeStatus.Text = "Offline"; break;

                }

                #endregion


                if (einstellungen.Überwachung.MessengerSettings.skypeSettings.writeStatusmeldung)
                    skype.CurrentUserProfile.MoodText = NormalStatus;



            }

            #endregion

            #endregion

            #endregion
            
            #region Werte zurücksetzten

            labelTimer.Text = "00:00:00:00";

            lbCPUAuslastung.Text = "...";
            lbRAMUsed.Text = "...";

            lbFSpeicherGB.Text = "...";
            lbBSpeicherGB.Text = "...";
                          
            listMarker.Items.Clear();

            #endregion

        }
                



        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectTimerProfil();
            }


        }

        /// <summary>
        /// Läst den User ein Timerprofil auswählen
        /// </summary>
        private void selectTimerProfil()
        {

            frmTimerprofilAuswahl TPA = new frmTimerprofilAuswahl(einstellungen);

            TPA.Location = new Point(Location.X, Location.Y + 59);

            TPA.ShowDialog();


            if (TPA.selectedProfil != null)
                selectedTimerProfil = TPA.selectedProfil;

            try
            {

                toolTip1.SetToolTip(labelTimer, selectedTimerProfil.name);
            }
            catch { }
        }

        #region Hotkeys

        /// <summary>
        /// Registriert die Hotkeys: Markererstellen, Aufnahmestart - und stop
        /// </summary>
        public void registerHotkeys()
        {

            //MarkerHotkey:
            RegisterHotKey(this.Handle, 1, getDinger(einstellungen.Marker.MarkerKeyAlt,
                einstellungen.Marker.MarkerKeyShift,
                einstellungen.Marker.MarkerKeyStrg),
                (int)einstellungen.Marker.MarkerKey);

        }

        /// <summary>
        /// Entregistriert die Hotkeys
        /// </summary>
        private void unregisterHotKeys()
        {
            UnregisterHotKey(this.Handle, 1); //Makerhotkey
        }

        protected override void WndProc(ref Message m)
        {

            //Markerhotkey:
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
                makeNewMarker();

            base.WndProc(ref m);
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MOD_CONTROL = 0x0002;
        const int MOD_ALT = 0x0001;
        const int MOD_SHIFT = 0x0004;
        const int WM_HOTKEY = 0x0312;

        private int getDinger(bool alt, bool strg, bool shift)
        {
            int vor = 0;


            if (alt == true)
            {
                vor += MOD_ALT;
            }
            if (shift == true)
            {
                vor += MOD_SHIFT;
            }
            if (strg == true)
            {
                vor += MOD_CONTROL;
            }
            return vor;

        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            //Einstellungen die auf der Mainform gemacht werden können werden hier gespeichert.

            stopSession();

            einstellungen.Timer.SelectedTimerProfil = selectedTimerProfil;

            einstellungen.save();



            unregisterHotKeys(); //Hotkeys werden wird deregistriert

        }

        #region Marker

        public List<string> lMarker = new List<string>();

        /// <summary>
        /// Erstellt einen neuen Marker bzw. neue Markerliste
        /// </summary>
        private void makeNewMarker()
        {

            lMarker.Add(Session.Timer.TimeString);
            listMarker.Items.Add(Session.Timer.TimeString);
            frmÜFenster.showMessage("Marker erstellt (" + Session.Timer.TimeString + ")", Color.FromArgb(38, 38, 38), 2);

        }

        /// <summary>
        /// KOnvertiert die erstellen Markerdaten in eine Datei
        /// </summary>
        private void createMarkerFile()
        {
            string FileName = einstellungen.Marker.MarkerSpeicherort + "\\" + DateTime.Now.Year + "_" + DateTime.Now.Month
                + "_" + DateTime.Now.Day + " " + DateTime.Now.Hour
                + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second
                + " Session " + einstellungen.SessionValue;

            if (lMarker.Count != 0)
            {

                if (einstellungen.Marker.MarkerFormat == 0) //Format = .txt
                {

                    using (System.IO.StreamWriter SW = new System.IO.StreamWriter(@FileName + ".txt", true))
                    {

                        foreach (string time in lMarker)
                        {

                            SW.WriteLine();
                            SW.WriteLine(time);


                        }
                        SW.Dispose();
                        SW.Close();

                    }


                }
                else
                {
                    //Format = .wav
                }
            }

        }


        #endregion

        private void bOpenÜFenster_Click(object sender, EventArgs e)
        {
            frmÜFenster.Close();
            frmÜFenster = new frmÜFenster();
            frmÜFenster.Show();

            frmÜFenster.Location = ÜFensterLocation;

        }

        private void sliderLautsprecher_ValueChanged(object sender, EventArgs e)
        {

            SoundController.setVolume(sliderLautsprecher.Value);


        }
    }
 
}

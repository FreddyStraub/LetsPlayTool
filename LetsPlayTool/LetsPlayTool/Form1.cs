using LetsPlayTool.Dialogs;
using LetsPlayTool.Update;
using Microsoft.Win32;
using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
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
            loadSettings();



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


                Updater updater = new Updater();

            if (updater.canUpdate)
            {
                if (updater.UpdateAvailable())
                    updater.update();

            }


            if (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool\\LetsPlayToolSetup.exe"))
            {
                try
                {
                    System.IO.File.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool\\LetsPlayToolSetup.exe");

                }
                catch { }
            }



        }

        /// <summary>
        /// Lädt die Einstellungen und setzt sie.
        /// </summary>
        private void loadSettings()
        {


            if (!System.IO.Directory.Exists("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool"))
                System.IO.Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool");

            //Einstellungen laden wenn vorhanden, ansonsten erstellen.
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

            einstellungen.SetMissingOptions();

            selectedTimerProfil = einstellungen.selectedTimerProfile;

            
            if (einstellungen.Messenger.Skype.active == true)
                skype = new Skype();


            #region Überwachung

            if (selectedTimerProfil != null)
                selectedTimerProfil = einstellungen.selectedTimerProfile;

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


            if (einstellungen.Messenger.Skype.active)
            {
                if (skype.Client.IsRunning)
                {
                    try
                    {

                        skype.Attach();

                    }
                    catch
                    {
                        einstellungen.Messenger.Skype.active = false;
                        einstellungen.save();
                        einstellungen = einstellungen.load();

                        MessageBox.Show("Verbindung mit Skype nicht möglich!");


                    }
                }

            }

            ValueUpdater.Start();

            #region Messenger

            setSteamStatus();
            setTeamspeakStatus();
            setDiscordStatus();

            if (einstellungen.Messenger.Skype.active)
                setSkyeLabelStatus();

            setMailClientStatus();

            #endregion

            #region ShowÜFensterButton

            if (einstellungen.Überwachung.ShowÜFenster == true)
            {

                bShowÜFenster.Visible = true;

            }else
            {
                bShowÜFenster.Visible = false;

            }

            #endregion


            #region MarkerLabel setzen

            string MarkerLabelTTip = "Drücke:\n";

            if (einstellungen.Marker.MarkerKeyStrg)
                MarkerLabelTTip += "Strg + ";

            if (einstellungen.Marker.MarkerKeyAlt)
                MarkerLabelTTip += "Alt + ";

            if (einstellungen.Marker.MarkerKeyShift)
                MarkerLabelTTip += "Shift + ";

            MarkerLabelTTip += einstellungen.Marker.MarkerKey + "\num einen Marker zu erstellen";



            toolTip1.SetToolTip(lbMarker, MarkerLabelTTip);

            #endregion

            unregisterHotKeys();
            registerHotkeys();

            sliderLautsprecher.Value = (int)LPTSound.SoundController.GetMasterVolume();

            try
            {

                rohPfad = mailClient.ToString().Substring(1);
                rohPfad = rohPfad.Substring(0, rohPfad.Length - 26);

            }
            catch { lbMailClient.Text = "Kein Mailclient gefunden!"; }

            #region Timer

            selectedTimerProfil = einstellungen.selectedTimerProfile;

            try

            {
                toolTip1.SetToolTip(labelTimer, "Ausgewähltes Timerprofil: " + selectedTimerProfil.name + " / Rechtsklick um ein Timerprofil auszuwählen!");

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

            unregisterHotKeys();

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

        public Point ÜFensterLocation = new Point();


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


                //Unwichtig?
                #region 0 Time
                //if (Session.Timer.milliseconds < 100 & Session.Timer.seconds < 1)
                //{

                //    if (t.ListViewItem.Text == "00:00:00:00")

                //    {


                //        if (t.Text != "")
                //        {

                //            showSmallMessage(panelTimer, t.Text, t.ListViewItem.BackColor);

                //        }
                //        else
                //        {
                //            showSmallMessage(panelTimer, "00:00:00:00", t.ListViewItem.BackColor);

                //        }

                //    }

                //}

                #endregion
                if (t.stopwatch == null)
                {

                    #region Normale Time/Message

                    if (t.Stunden == Session.Timer.st.Elapsed.Hours)
                    {
                        if (t.Minuten == Session.Timer.st.Elapsed.Minutes)
                        {
                            if (t.Sekunden == Session.Timer.st.Elapsed.Seconds)
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
                    }

                    #endregion


                }else{ 
                
                    #region LoopMessage

                    if(t.stopwatch.Elapsed.Hours == t.Stunden)
                    {
                        if (t.stopwatch.Elapsed.Minutes == t.Minuten)
                        {
                            if (t.stopwatch.Elapsed.Seconds == t.Sekunden)
                            {


                                if (t.Text != "")
                                {

                                    showSmallMessage(panelTimer, t.Text, t.ListViewItem.BackColor); //wenn Text dann text anzeigen.
                                    frmÜFenster.showMessage(t.Text, t.ListViewItem.BackColor, 3);

                                }
                                else
                                {

                                    showSmallMessage(panelTimer, Session.Timer.TimeString, t.ListViewItem.BackColor); // wenn kein Text, dann Zeit anzeigen.
                                    frmÜFenster.showMessage(Session.Timer.TimeString, t.ListViewItem.BackColor, 3);

                                }

                                t.stopwatch.Restart();

                            }


                        }

                    }


                    #endregion

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

            }


            #endregion

            #region Messenger

            setDiscordStatus();
            setTeamspeakStatus();
            setMailClientStatus();
            setSteamStatus();

            #endregion


            #endregion

            #region lautsprecher

            sliderLautsprecher.Value = (int)LPTSound.SoundController.GetMasterVolume();

            #endregion


        } //Mainactor!!!!!!!!!!!!!!!!!!

        /// <summary>
        /// Setzt den aktuellen TeamspeakStatus in das Label.
        /// </summary>
        private void setTeamspeakStatus()
        {

            if (Process.GetProcessesByName("ts3client_win64").Length > 0 | Process.GetProcessesByName("ts3client_win32").Length > 0 | Process.GetProcessesByName("ts2client_win64").Length > 0 | Process.GetProcessesByName("ts2client_win32").Length > 0)
            {
                lbTeamspeakStatus.Text = "Offen";
                lbTeamspeakStatus.ForeColor = Color.Lime;
            }
            else
            {

                lbTeamspeakStatus.Text = "Geschlossen";
                lbTeamspeakStatus.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Setzt den aktuellen MailClientStatus in das Label.
        /// </summary>



        object mailClient = Registry.GetValue(@"HKEY_CLASSES_ROOT\mailto\shell\open\command", "", "none");

        string rohPfad;

        #region SetStatus

        private void setMailClientStatus()
        {
            //  throw new NotImplementedException();


            try
            {
                string processname = System.IO.Path.GetFileNameWithoutExtension(rohPfad);


                if (Process.GetProcessesByName(processname).Length > 0)
                {
                    lbMailClient.Text = "Gestartet";
                    lbMailClient.ForeColor = Color.Lime;
                }
                else
                {

                    lbMailClient.Text = "Geschlossen";
                    lbMailClient.ForeColor = Color.Red;
                }

            }
            catch
            {
                lbMailClient.Text = "Nicht kompatibel!";
                lbMailClient.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// Setzt den Status von Steam in das Label.
        /// </summary>
        private void setSteamStatus()
        {

            if (Process.GetProcessesByName("Steam").Length > 0 | Process.GetProcessesByName("steam").Length > 0)
            {
                lbSteamStatus.Text = "Läuft";
                lbSteamStatus.ForeColor = Color.Lime;
            }
            else
            {

                lbSteamStatus.Text = "Geschlossen";
                lbSteamStatus.ForeColor = Color.Red;
            }


        }

        /// <summary>
        /// Setzt den Status von Discord in das Label.
        /// </summary>
        private void setDiscordStatus()
        {
            if (Process.GetProcessesByName("DiscordPTB").Length > 0 | Process.GetProcessesByName("Discord").Length > 0)
            {
                lbDiscordSMStatus.Text = "Offen";
                lbDiscordSMStatus.ForeColor = Color.Lime;
            }
            else
            {

                lbDiscordSMStatus.Text = "Geschlossen";
                lbDiscordSMStatus.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Zeigt den aktuellen Skypestatus im Label an.
        /// </summary>
        private void setSkyeLabelStatus()
        {

            if (einstellungen.Messenger.Skype.active)
            {

                if (skype.Client.IsRunning)
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
                else
                {

                    lbSkypeStatus.Text = "Kein Skype Client gefunden!";
                    lbSkypeStatus.ForeColor = Color.Orange;

                }


            }
            else
            {

                lbSkypeStatus.Text = "Deaktiviert!";
                lbSkypeStatus.ForeColor = Color.Orange;

            }
        }

        /// <summary>
        /// Setzt den eingestellen Status
        /// </summary>
        private void setSkypeStatus(int status)
        {
           
                switch (status)
                {
                    case 0: skype.ChangeUserStatus(TUserStatus.cusOnline); break;
                    case 1: skype.ChangeUserStatus(TUserStatus.cusAway); break;
                    case 2: skype.ChangeUserStatus(TUserStatus.cusDoNotDisturb); break;
                    case 3: skype.ChangeUserStatus(TUserStatus.cusInvisible); break;
                    case 4: skype.ChangeUserStatus(TUserStatus.cusOffline); break;

                }
          
        }

        #endregion

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

            if (messageSecurity)
            {

                LetsPlayToolMessage.Small S = new LetsPlayToolMessage.Small(message);

                S.TopLevel = false;
                S.AutoScroll = true;

                panel.Controls.Add(S);

                S.BringToFront();

                S.Show();
                S.ShowMessage.Start();

                messageSecurity = false;

            }

        }

        /// <summary>
        /// Zeigt ein kleine Nachricht in dem Panel an.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="message"></param>
        private void showSmallMessage(Panel panel, string message, Color color)
        {

            if (messageSecurity)
            {
                LetsPlayToolMessage.Small S = new LetsPlayToolMessage.Small(message, color);

                S.TopLevel = false;
                S.AutoScroll = true;

                panel.Controls.Add(S);

                S.BringToFront();

                S.Show();
                S.ShowMessage.Start();

                messageSecurity = false;

            }
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

        public bool messageSecurity;

        #endregion

        frmÜFenster frmÜFenster = new frmÜFenster(); //Kleines Überwachungsfenster

        /// <summary>
        /// Startet die Session und alle Funktionen.
        /// </summary>
        public void startSession()
        {

            if (selectedTimerProfil != null)
            {

                Session = new LetsPlayTool.Session.Session(selectedTimerProfil, einstellungen);


                ValueUpdater.Stop();

                Mainactor.Start();
                Session.Timer.st.Start(); //Startet die Stopwatch für MainTimer

                einstellungen.SessionValue += 1;

                listMarker.Items.Clear();

                if (einstellungen.Überwachung.ShowÜFenster)
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

                //If Time.Loop --> Stopwatch Für Loop starten
                foreach (Time t in Session.Timer.getTimes())
                {

                    if(t.isLoop)
                    {
                        t.stopwatch = new Stopwatch();
                        t.stopwatch.Start();
                    }

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

                if (einstellungen.Messenger.Skype.active)
                {

                    if (skype.Client.IsRunning)
                    {

                        setSkypeStatus(einstellungen.Messenger.Skype.statusInAufnahme);

                        if (einstellungen.Messenger.Skype.writeStatusmeldung)
                        {

                            NormalStatus = skype.CurrentUserProfile.MoodText;
                            skype.CurrentUserProfile.MoodText = einstellungen.Messenger.Skype.Statusmeldung;

                        }
                    }
                }

                #endregion

                #region Discord

                setDiscordStatus();

                #endregion

                #region Teamspeak

                setTeamspeakStatus();
                #endregion



                #endregion

            }
            else
            {

                showSmallMessage(panelTimer, "Bitte wähle ein Timerprofil aus!", Color.DarkRed);

            }
        }

        /// <summary>
        /// Stoppt die Session und alle Funktionen
        /// </summary>
        public void stopSession()
        {
            createMarkerFile();
            Mainactor.Stop();

            ValueUpdater.Start();

            einstellungen.save();

            ÜFensterLocation = frmÜFenster.Location;

            #region Messenger

            #region Skype

            #region Status

            

            try
            {

                if (einstellungen.Messenger.Skype.active)
                {


                    if (skype.Client.IsRunning)
                    {

                        setSkypeStatus(einstellungen.Messenger.Skype.statusNachAufnahme);
                        setSkyeLabelStatus();

                        if (einstellungen.Messenger.Skype.writeStatusmeldung)
                            skype.CurrentUserProfile.MoodText = NormalStatus;

                    }

                }

            }
            catch { }
            #endregion

            #endregion

            #region Discord

            setDiscordStatus();

            #endregion

            #region Teamspeak

            setTeamspeakStatus();
            #endregion


            #endregion

            if(labelTimer.Text != "00:00:00:00")
                if (einstellungen.Überwachung.OpenÜberwachungOrdner)
                     Process.Start(einstellungen.Überwachung.ÜberwachungOrdner);



            #region Werte zurücksetzten

            labelTimer.Text = "00:00:00:00";

            lbCPUAuslastung.Text = "...";
            lbCPUAuslastung.BackColor = Color.Transparent;

            lbRAMUsed.Text = "...";
            lbRAMUsed.BackColor = Color.Transparent;

            lbFSpeicherGB.Text = "...";
            lbFSpeicherGB.BackColor = Color.Transparent;

            lbBSpeicherGB.Text = "...";
            lbBSpeicherGB.BackColor = Color.Transparent;


            listMarker.Items.Clear();

            lMarker.Clear();

            //ÜFenster

            frmÜFenster.lbCPUAuslastung.Text = "...";
            frmÜFenster.lbRAMUsed.Text = "...";

            frmÜFenster.lbCPUAuslastung.BackColor = Color.Transparent;
            frmÜFenster.lbRAMUsed.BackColor = Color.Transparent;


            frmÜFenster.lbTimer.Text = "00:00:00:00";


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

                toolTip1.SetToolTip(labelTimer, "Ausgewähltes Timerprofil: " + selectedTimerProfil.name + " / Rechtsklick um ein Timerprofil auszuwählen!");
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

            RegisterHotKey(this.Handle, 2, 0,(int)einstellungen.Allgemeines.AufnahmeStartKey);
            RegisterHotKey(this.Handle, 3, 0, (int)einstellungen.Allgemeines.AufnahmeStopKey);

        }

        /// <summary>
        /// Entregistriert die Hotkeys
        /// </summary>
        private void unregisterHotKeys()
        {
            UnregisterHotKey(this.Handle, 1); //Makerhotkey
            UnregisterHotKey(this.Handle, 2); //AufnahmeStartHotkey
            UnregisterHotKey(this.Handle, 3); //AufnahmeStopHotkey

        }

        protected override void WndProc(ref Message m)
        {

            //Markerhotkey:
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 1)
                makeNewMarker();

            //Aufnahme/Session Hotkeys
            //Start
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 2)
            {

                if(einstellungen.Allgemeines.AufnahmeStartKey == einstellungen.Allgemeines.AufnahmeStopKey)
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
                else
                {
                    startSession();
                    SessionRuns = true;
                }


            }
            
            //Stop
            if (m.Msg == WM_HOTKEY && (int)m.WParam == 3)
            {

                if (einstellungen.Allgemeines.AufnahmeStartKey != einstellungen.Allgemeines.AufnahmeStopKey)
                {

                    stopSession();
                    try
                    {

                        SessionRuns = false;

                    }catch(Exception ex)
                    { MessageBox.Show("Folgender Fehler ist aufgetreten: " + ex.ToString()); }
                }


            }

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

        /// <summary>
        /// Rechnet anhand der angaben den Wert für die Hotkeymodifier aus.
        /// </summary>
        /// <param name="alt"></param>
        /// <param name="strg"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
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

            einstellungen.selectedTimerProfile = selectedTimerProfil;

            einstellungen.save();

            ValueUpdater.Stop();

            unregisterHotKeys(); //Hotkeys werden wird deregistriert

        }

        #region Marker

        public List<string> lMarker = new List<string>();

        private bool creatingMarkerSecurity { get; set; }

        /// <summary>
        /// Erstellt einen neuen Marker bzw. neue Markerliste
        /// </summary>
        private void makeNewMarker()
        {

            if (SessionRuns == true)
            {

                lMarker.Add(Session.Timer.TimeString);
                listMarker.Items.Add(Session.Timer.TimeString);

                if (frmÜFenster.Visible == true)
                {

                    if (creatingMarkerSecurity)
                    {

                        frmÜFenster.Close();
                        frmÜFenster = new frmÜFenster();
                        frmÜFenster.Show();


                        frmÜFenster.Location = ÜFensterLocation;


                        frmÜFenster.showMessage("Marker erstellt (" + Session.Timer.TimeString + ")", Color.FromArgb(38, 38, 38), 2);

                        creatingMarkerSecurity = false;

                    }

                }


            }
        }

        /// <summary>
        /// KOnvertiert die erstellen Markerdaten in eine Datei
        /// </summary>
        private void createMarkerFile()
        {

            try {

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
                            SW.WriteLine("");
                            SW.WriteLine("______________________________________________________________________________________________");
                            SW.WriteLine("");
                            SW.WriteLine("Marker von der Aufnahme am " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year
                                + " um " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ".");
                            SW.WriteLine("");
                            SW.WriteLine("______________________________________________________________________________________________");
                            SW.WriteLine("");

                            foreach (string time in lMarker)
                            {

                                SW.WriteLine();
                                SW.WriteLine(time);


                            }
                            SW.WriteLine("");
                            SW.WriteLine("______________________________________________________________________________________________");
                            SW.WriteLine("");
                            SW.WriteLine("Erstellte mit dem LetsPlayTool von Wolf066LP");


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
            catch { }
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

            LPTSound.SoundController.SetMasterVolume(sliderLautsprecher.Value);
            
        }

        private void lbSkypeStatus_TextChanged(object sender, EventArgs e)
        {

            //Farbanpassung des Textes (SkypeStatus Label)
            switch (lbSkypeStatus.Text)
            {
                case "Online": lbSkypeStatus.ForeColor = Color.Lime; break;
                case "Abwesend": lbSkypeStatus.ForeColor = Color.Yellow; break;
                case "Beschäftigt": lbSkypeStatus.ForeColor = Color.Red; break;
                case "Als Offline anzeigen": lbSkypeStatus.ForeColor = Color.White; break;
                case "Offline": lbSkypeStatus.ForeColor = Color.White; break;
                case "Kein Skype Client gefunden!": lbSkypeStatus.ForeColor = Color.Orange; break;

            }
        }

        private void lbLautsprecher_Click(object sender, EventArgs e)
        {

            if (LPTSound.SoundController.ToggleMasterVolumeMute())
            {
                lbLautsprecher.ForeColor = Color.DarkRed;

            }else
            {
                lbLautsprecher.ForeColor = Color.White;

            }

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            sliderLautsprecher.Value = (int)LPTSound.SoundController.GetMasterVolume();
        }

        private void ValueUpdater_Tick(object sender, EventArgs e)
        {

            ÜFensterLocation = frmÜFenster.Location; //Überwachungsfenster Location speichern
            sliderLautsprecher.Value = (int)LPTSound.SoundController.GetMasterVolume();

            setSkyeLabelStatus();
            setTeamspeakStatus();
            setDiscordStatus();
            setMailClientStatus();
            setSteamStatus();

            creatingMarkerSecurity = true;
            messageSecurity = true;


        }

    }
 
}

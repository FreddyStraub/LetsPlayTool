using LetsPlayTool.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            loadSettings();

        }

        /// <summary>
        /// Lädt die Einstellungen und setzt sie.
        /// </summary>
        private void loadSettings()
        {

            einstellungen = einstellungen.load();

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


        public int Stunden { get; set; }
        public int Minuten { get; set; }
        public int Sekunden { get; set; }
        public int Millisekunden { get; set; }

        public TimerProfil selectedTimerProfil;

        string TimeString = ""; // == Das was im Timer angezeigt wird

        static PerformanceCounter cpuCounter; // globaler PerformanceCounter 
        static PerformanceCounter RAMCounter;

        int MainactorElapsedTicks = 0;
        int cpuTimervalue = 0;

        private void Mainactor_Tick(object sender, EventArgs e)
        {

            MainactorElapsedTicks++;

            #region Timer

            //Macht das die Zeit läuft und angezeigt wird

            #region Time

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


            #region aussehen

            string StringStunden = "";
            string StringMinuten = "";
            string StringSekunden = "";
            string StringMillisekunden = "";

            //Stunden
            if (Stunden < 10)
            {
                StringStunden = "0" + Stunden.ToString();
            }
            else
            {
                StringStunden = Stunden.ToString();
            }

            //Minuten
            if (Minuten < 10)
            {
                StringMinuten = "0" + Minuten.ToString();
            }
            else
            {
                StringMinuten = Minuten.ToString();
            }

            //Sekunden
            if (Sekunden < 10)
            {
                StringSekunden = "0" + Sekunden.ToString();
            }
            else
            {
                StringSekunden = Sekunden.ToString();
            }

            //Millisekunden
            if (Millisekunden < 10)
            {
                StringMillisekunden = "0" + Millisekunden.ToString();
            }
            else
            {
                StringMillisekunden = Millisekunden.ToString();
            }


            #endregion

            TimeString = StringStunden + ":" + StringMinuten + ":" + StringSekunden + ":" + StringMillisekunden;



            labelTimer.Text = TimeString;
            #endregion // Mácht das der Timer 


            //Macht, das bei eingestellter Zeit die Nachricht angezeigt wird
            #region Message


            foreach (Time t in getTimes())
            {


                #region 0 Time

                if (t.ListViewItem.Text == "00:00:00:00" && TimeString == "00:00:00:01")
                    showSmallMessage(panelTimer, t.Text, t.ListViewItem.BackColor);


                #endregion

                if (t.ListViewItem.Text == TimeString)
                {

                    if (t.Text != "")
                    {

                        showSmallMessage(panelTimer, t.Text, t.ListViewItem.BackColor); //wenn Text dann text anzeigen.

                    }
                    else
                    {

                        showSmallMessage(panelTimer, t.ListViewItem.Text, t.ListViewItem.BackColor); // wenn kein Text, dann Zeit anzeigen.

                    }
                }



            }
            #endregion

            #endregion

            #region Überwachung

            #region Speicher

            System.IO.DriveInfo[] Drives = System.IO.DriveInfo.GetDrives(); // alle Laufwerke auslesen

            string drive = System.IO.Path.GetPathRoot(einstellungen.Überwachung.ÜberwachungOrdner); // = Das laufwerk welches im PFad des Users steht

            long freierSpeicherMB = 0;
            long belegterSpeicherMB = 0;
            long freierSpeicherGB = 0;
            long belegterSpeicherGB = 0;

            foreach (System.IO.DriveInfo d in Drives)
            {
                if (d.Name == drive)
                {

                    freierSpeicherMB = d.TotalFreeSpace / (1024 * 1024);
                    belegterSpeicherMB = d.TotalSize / (1024 * 1024) - freierSpeicherMB;

                    freierSpeicherGB = d.TotalFreeSpace / (1024 * 1024 * 1024);
                    belegterSpeicherGB = d.TotalSize / (1024 * 1024 * 1024) - freierSpeicherGB;
                }
            }

            //Ausgabe an User
            lbBSpeicherMB.Text = belegterSpeicherGB.ToString() + "GB";
            lbFSpeicherMB.Text = freierSpeicherGB.ToString() + "GB";

            toolTip1.SetToolTip(lbBSpeicherMB, belegterSpeicherMB.ToString() + "MB");
            toolTip1.SetToolTip(lbFSpeicherMB, freierSpeicherMB.ToString() + "MB");

            #endregion
            
            #region CPU & RAM


            if (MainactorElapsedTicks == cpuTimervalue + 100)
            {

                lbCPUAuslastung.Text = ((int)cpuCounter.NextValue()).ToString() + "%"; //CPU-Auslastung in Prozent
                lbRAMUsed.Text = ((int)RAMCounter.NextValue()).ToString() + "MB"; //Verfügbarer RAM in Megabyte

                cpuTimervalue += 100;

            }


            #endregion

            #endregion
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

            startSession();

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

        #endregion

        /// <summary>
        /// Startet die Session und alle Funktionen.
        /// </summary>
        private void startSession()
        {

            InitialisierePerformanceCounter();

            Mainactor.Start();

            einstellungen.SessionValue += 1;

            listMarker.Items.Clear();

            #region Get Times

            if (selectedTimerProfil != null)
            {


                getTimes();

            }
            else
            {

                stopSession();
                showSmallMessage(panelTimer, "Bitte wähle ein Timerprofil aus!", Color.Red);

            }
            #endregion

        }

        /// <summary>
        /// Stoppt die Session und alle Funktionen
        /// </summary>
        private void stopSession()
        {
            createMarkerFile();
            Mainactor.Stop();

        }

        /// <summary>
        /// INitialisiert den Performencecounter für CPU
        /// </summary>
        static void InitialisierePerformanceCounter()
        {
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            RAMCounter = new PerformanceCounter();
            RAMCounter.CategoryName = "Memory";
            RAMCounter.CounterName = "Available MBytes";



        }  // "_Total" entspricht der gesamten CPU Auslastung, Bei Computern mit mehr als 1 logischem Prozessor: "0" dem ersten Core, "1" dem zweiten...


        /// <summary>
        /// Listet die Zeiten des aktuellen ´TimerProfiles auf.
        /// </summary>
        /// <returns></returns>
        private List<Time> getTimes()
        {

            List<Time> Times = new List<Time>();

            foreach (Time t in selectedTimerProfil.Times)
            {
                Times.Add(t);
            }

            return Times;
        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectTimerProifil();
            }


        }

        /// <summary>
        /// Läst den User ein Timerprofil auswählen
        /// </summary>
        private void selectTimerProifil()
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

            lMarker.Add(TimeString);
            listMarker.Items.Add(TimeString);


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
    }
}

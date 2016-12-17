using LetsPlayTool.Einstellungen_Tabs;
using LetsPlayTool.Einstellungen_Tabs.Messenger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    [Serializable]

    public class Einstellungen
    {

        private static string EinstellungenPfad = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool";

        public Einstellungen() { }

        public int SessionValue { get; set; }

        public TimerProfil selectedTimerProfile { get; set; }

        /// <summary>
        /// Speicher die Einstellungen
        /// </summary>
        public void save()
        {

            string pfad = EinstellungenPfad + "\\Settings.pilz";

            System.IO.File.Delete(pfad);

            FileStream FS = new FileStream(pfad, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();
            

        }

        /// <summary>
        /// Lädt Einstellungen
        /// </summary>
        public Einstellungen load() {

            Einstellungen e = new Einstellungen();

            string pfad = EinstellungenPfad + "\\Settings.pilz";

            FileStream FS = new FileStream(pfad, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            e = (Einstellungen)BF.Deserialize(FS);

            FS.Dispose();

            return e;

        }

        /// <summary>
        /// Setzt die Einstellungen auf den Standartwert zurück.
        /// </summary>
        public void SetStandartValues()
        {

            AllgemeinesStandartValues();
            MarkerStandartValues();
            ProgrammeStandartValues();
            TimerStandartValues();
            ÜberwachungStandartValues();
            MessengerStandartValues();


        }
        

        private void AllgemeinesStandartValues()
        {
            #region Allgemeines

            AllgemeinesTabEinstellungen newAllgemeines = new AllgemeinesTabEinstellungen();

            newAllgemeines.AufnahmeStopKey = Keys.NumPad0;
            newAllgemeines.AufnahmeStartKey = Keys.NumPad0;

            newAllgemeines.Erinerrungen = "";
            newAllgemeines.ShowIErinerrung = false;
            newAllgemeines.ErinerrungenAnzeigeDauer = 4;

            newAllgemeines.ShowTimeAfterRecording = false;
            newAllgemeines.ShowTimeAfterRecordingDuration = 4;



            Allgemeines = newAllgemeines;

            #endregion

        }
        private void MarkerStandartValues()
        {
            #region Marker

            MarkerTabEinstellungen newMarker = new MarkerTabEinstellungen();

            newMarker.MarkerFormat = 0;
            newMarker.MarkerKey = Keys.M;

            newMarker.MarkerKeyAlt = true;
            newMarker.MarkerKeyShift = true;
            newMarker.MarkerKeyStrg = true;

            newMarker.MarkerSpeicherort = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

            Marker = newMarker;

            #endregion

        }
        private void ProgrammeStandartValues()
        {
            #region Programme

            ProgrammeTabEinstellungen newProgramme = new ProgrammeTabEinstellungen();

            newProgramme.Programme = new List<string>();

            Programme = newProgramme;

            #endregion

        }
        private void TimerStandartValues()
        {
            #region Timer

            TimerTabEinstellungen newTimer = new TimerTabEinstellungen();

            newTimer.TimerProfiles = new List<TimerProfil>();


            newTimer.TimerProfiles.Add(new TimerProfil("Standard"));

            selectedTimerProfile = newTimer.TimerProfiles[0];

            Timer = newTimer;

            #endregion

        }
        private void ÜberwachungStandartValues()
        {
            #region Überwachung

            ÜberwachungTabEinstellungen newÜberwachung = new ÜberwachungTabEinstellungen();

            newÜberwachung.ÜberwachungOrdner = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            newÜberwachung.ÜShowCPU = true;
            newÜberwachung.ÜShowSpeicherort = true;
            newÜberwachung.ÜShowRAM = true;
            newÜberwachung.OpenÜberwachungOrdner = false;


            newÜberwachung.ShowÜFenster = false;
            newÜberwachung.ShowÜFensterTimer = true;
            newÜberwachung.ShowÜFensterCPU = true;
            newÜberwachung.ShowÜFensterRAM = true;

            newÜberwachung.ShowSkype = false;
            newÜberwachung.ShowTeamspeak = false;
            newÜberwachung.ShowDiscord = false;
            newÜberwachung.ShowMail = false;
            newÜberwachung.ShowSteam = false;


            Überwachung = newÜberwachung;


            #endregion

        }


        private void MessengerStandartValues()
        {
            Messenger = new MessengerTabEinstellungen();

            Messenger.Skype = new SkypeSettings();

            Messenger.Skype.active = false;
            Messenger.Skype.statusInAufnahme = 3;
            Messenger.Skype.statusNachAufnahme = 0;
            Messenger.Skype.writeStatusmeldung = false;
            Messenger.Skype.Statusmeldung = "Ich nehme jetzt auf!";

        }


        /// <summary>
        /// Setzt neue oder fehlende Einstellungen auf ihren Standartwert.
        /// </summary>
        public void SetMissingOptions()
        {
            //Allgemeines
            if(Allgemeines == null)
            {
                AllgemeinesStandartValues();
            }

            //Marker
            if (Marker == null)
            {
                MarkerStandartValues();
            }

            //Programme
            if (Programme == null)
            {
                ProgrammeStandartValues();
            }

            //Timer
            if (Timer == null)
            {
                TimerStandartValues();
            }

            //Überwachung
            if (Überwachung == null)
            {
                ÜberwachungStandartValues();
            }

            //Messenger
            if (Messenger == null)
            {
                MessengerStandartValues();
            }



        }

        public AllgemeinesTabEinstellungen Allgemeines;
        public MarkerTabEinstellungen Marker;
        public ProgrammeTabEinstellungen Programme;
        public TimerTabEinstellungen Timer;
        public ÜberwachungTabEinstellungen Überwachung;
        public MessengerTabEinstellungen Messenger;

    }



}

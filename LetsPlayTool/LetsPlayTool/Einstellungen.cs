using LetsPlayTool.Einstellungen_Tabs;
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

        private static string EinstellungenPfad = Application.StartupPath;

        public Einstellungen() { }

        public int SessionValue { get; set; }

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

            #region Allgemeines

            AllgemeinesTabEinstellungen newAllgemeines = new AllgemeinesTabEinstellungen();

            newAllgemeines.AufnahmeStopKey = Keys.NumPad0;
            newAllgemeines.AufnahmeStartKey = Keys.NumPad0;

            newAllgemeines.Erinerrungen = "";
            newAllgemeines.ShowIErinerrung = false;
            newAllgemeines.ErinerrungenAnzeigeDauer = 4;

            newAllgemeines.ShowÜFenster = false;
            newAllgemeines.ShowÜFensterTimer = true;
            newAllgemeines.ShowÜFensterCPU = true;
            newAllgemeines.ShowÜFensterRAM = true;

            Allgemeines = newAllgemeines;

            #endregion

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

            #region Programme

            ProgrammeTabEinstellungen newProgramme = new ProgrammeTabEinstellungen();

            newProgramme.Programme = new List<string>();
            
            Programme = newProgramme;

            #endregion

            #region Timer

            TimerTabEinstellungen newTimer = new TimerTabEinstellungen();

            newTimer.TimerProfiles = new List<TimerProfil>();


            newTimer.TimerProfiles.Add(new TimerProfil("Standart"));

            newTimer.SelectedTimerProfil = newTimer.TimerProfiles[0];

            Timer = newTimer;

            #endregion

            #region Überwachung

            ÜberwachungTabEinstellungen newÜberwachung = new ÜberwachungTabEinstellungen();

            newÜberwachung.ÜberwachungOrdner = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            newÜberwachung.ÜShowCPU = true;
            newÜberwachung.ÜShowSpeicherort = true;
            newÜberwachung.ÜShowRAM = true;

            Überwachung = newÜberwachung;

            #region Messenger


            newÜberwachung.MessengerSettings = new Einstellungen_Tabs.Messenger.Settings();
            newÜberwachung.MessengerSettings.skypeSettings.active = false;

            newÜberwachung.MessengerSettings.skypeSettings.statusInAufnahme = 2;
            newÜberwachung.MessengerSettings.skypeSettings.statusNachAufnahme = 0;

            newÜberwachung.MessengerSettings.skypeSettings.Statusmeldung = "Ich fange jetzt an aufzunehmen!!!";
            newÜberwachung.MessengerSettings.skypeSettings.writeStatusmeldung = false;

            #endregion

            #endregion

        }


        public AllgemeinesTabEinstellungen Allgemeines;
        public MarkerTabEinstellungen Marker;
        public ProgrammeTabEinstellungen Programme;
        public TimerTabEinstellungen Timer;
        public ÜberwachungTabEinstellungen Überwachung;


    }



}

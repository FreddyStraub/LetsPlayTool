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

        /// <summary>
        /// Speicher die Einstellungen
        /// </summary>
        public void save()
        {

            string pfad = EinstellungenPfad + "\\Settings";

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

            string pfad = EinstellungenPfad + "\\Settings";

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
            newAllgemeines.ShowIErinerrung = true;
            newAllgemeines.ShowÜFenster = false;
            newAllgemeines.ShowÜFensterTimer = false;


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

            Timer = newTimer;

            #endregion

            #region Überwachung

            ÜberwachungTabEinstellungen newÜberwachung = new ÜberwachungTabEinstellungen();

            newÜberwachung.ÜberwachungOrdner = "";
            newÜberwachung.ÜShowCPU = true;
            newÜberwachung.ÜShowGPU = true;
            newÜberwachung.ÜShowSpeicherort = false;

            Überwachung = newÜberwachung;

            #endregion

        }

        public AllgemeinesTabEinstellungen Allgemeines;
        public MarkerTabEinstellungen Marker;
        public ProgrammeTabEinstellungen Programme;
        public TimerTabEinstellungen Timer;
        public ÜberwachungTabEinstellungen Überwachung;


    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    [Serializable]

    public class Einstellungen
    {

        public Einstellungen() { }

        /// <summary>
        /// Speicher die Einstellungen
        /// </summary>
        public void save() { }

        /// <summary>
        /// Lädt Einstellungen
        /// </summary>
        public void load() { }

        #region Einstellungen

        #region Allgemein
        public Keys AufnahmeStartKey;
        public Keys AufnahmeStopKey;

        public bool ShowÜFenster;
            public bool ShowÜFensterTimer;
        

        public bool ShowIErinerrung;

        #endregion

        #region Marker

        public string MarkerSpeicherort;
        public string MarkerFormat;

        public bool MarkerKeyStrg;
        public bool MarkerKeyShift;
        public bool MarkerKeyAlt;
        public Keys MarkerKey;



        #endregion

        #region Programme

        public List<string> Programme;

        #endregion

        #region Timer

        List<TimerProfil> TimerProfiles;


        #endregion

        #region Überwachung

        public string ÜberwachungOrdner;

        public bool ÜShowSpeicherort;
        public bool ÜShowCPU;
        public bool ÜShowGPU;

        #endregion

        #endregion

    }
}

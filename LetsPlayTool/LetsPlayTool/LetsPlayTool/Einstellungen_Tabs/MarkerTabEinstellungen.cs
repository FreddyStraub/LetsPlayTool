using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs
{
    [Serializable]
    public class MarkerTabEinstellungen
    {

        public string MarkerSpeicherort;
        public int MarkerFormat;

        public bool MarkerKeyStrg;
        public bool MarkerKeyShift;
        public bool MarkerKeyAlt;
        public Keys MarkerKey;


    }
}

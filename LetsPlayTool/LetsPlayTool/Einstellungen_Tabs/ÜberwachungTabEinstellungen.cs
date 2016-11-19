using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Einstellungen_Tabs
{
    [Serializable]
    public class ÜberwachungTabEinstellungen
    {
        
        public string ÜberwachungOrdner;

        public bool ÜShowSpeicherort;
        public bool ÜShowCPU;
        public bool ÜShowRAM;


        public Messenger.Settings MessengerSettings;

        public bool OpenÜberwachungOrdner;


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Einstellungen_Tabs.Messenger
{
    [Serializable]
    public class SkypeSettings
    {

        public bool active { get; set; }

        public int statusInAufnahme { get; set; }
        public int statusNachAufnahme { get; set; }

        public string Statusmeldung { get; set; }
        public bool writeStatusmeldung { get; set; }

    }
}

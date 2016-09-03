using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Einstellungen_Tabs.Messenger
{
    [Serializable]
    public class Settings
    {

        public SkypeSettings skypeSettings { get; set; }

        public Settings()
        {

            skypeSettings = new SkypeSettings();

        }
    }
}

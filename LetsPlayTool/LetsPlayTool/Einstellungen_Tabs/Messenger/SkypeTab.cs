using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs.Messenger
{
    public partial class SkypeTab : Form
    {
        public SkypeTab()
        {
            InitializeComponent();
        }

        //TODO: set - getSettigns

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        public void setSettings(SkypeSettings settings)
        {

            checkBox1.Checked = settings.active;

        }

        /// <summary>
        /// Gibt die aktuellen SkypeSettings zurück
        /// </summary>
        /// <returns></returns>
        public SkypeSettings getSettings()
        {

            SkypeSettings newSks = new SkypeSettings();

            newSks.active = checkBox1.Checked;

            return newSks;
        }

    }
}

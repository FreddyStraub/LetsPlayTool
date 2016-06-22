using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs
{
    public partial class MarkerTab : Form
    {
        public MarkerTab()
        {
            InitializeComponent();
        }

        private void MarkerTab_Load(object sender, EventArgs e)
        {

        }

        private void bKey_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lädt die Einstellungen.
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(MarkerTabEinstellungen Settings)
        {

            bKey.ButtonText = Settings.MarkerKey.ToString();
            checkAlt.Checked = Settings.MarkerKeyAlt;
            checkShift.Checked = Settings.MarkerKeyShift;
            checkStrg.Checked = Settings.MarkerKeyStrg;
            
            tbSpeicherort.Text = Settings.MarkerSpeicherort;

            cbFormat.selectedIndex = Settings.MarkerFormat;


        }

        /// <summary>
        /// Gibt die aktuellen MarkerTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public MarkerTabEinstellungen getSettings()
        {

            MarkerTabEinstellungen newSettings = new MarkerTabEinstellungen();

            newSettings.MarkerKeyStrg = checkStrg.Checked;
            newSettings.MarkerKeyShift = checkShift.Checked;
            newSettings.MarkerKeyAlt = checkAlt.Checked;
            newSettings.MarkerKey = (Keys)Enum.Parse(typeof(Keys), bKey.ButtonText);
            
            return newSettings;
        }

    }
}

using System;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs
{
    public partial class MarkerTab : Form
    {
        public MarkerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lädt die Einstellungen.
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(MarkerTabEinstellungen Settings)
        {

            bKey.Text = Settings.MarkerKey.ToString();
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
            newSettings.MarkerKey = (Keys)Enum.Parse(typeof(Keys), bKey.Text);

            newSettings.MarkerFormat = cbFormat.selectedIndex;
            newSettings.MarkerSpeicherort = tbSpeicherort.Text;

            return newSettings;
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            if(fbdSpeicherort.ShowDialog() == DialogResult.OK)
            {

                tbSpeicherort.Text = fbdSpeicherort.SelectedPath;

            }
      

        }
    }
}

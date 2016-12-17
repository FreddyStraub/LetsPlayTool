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
    public partial class AllgemeinesTab : Form
    {
        public AllgemeinesTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(AllgemeinesTabEinstellungen Settings)
        {

            bAufnhameStop.Text = Settings.AufnahmeStopKey.ToString();
            bAufnhameStart.Text = Settings.AufnahmeStartKey.ToString();

            switchIErinerrungen.Value = Settings.ShowIErinerrung;
            tbIErinerrungen.Text = Settings.Erinerrungen;
            nudDuration.Value = Settings.ErinerrungenAnzeigeDauer;

            checkShowTimeAfterRecording.Value = Settings.ShowTimeAfterRecording;
            nudShowTimeAfterRecording.Value = Settings.ShowTimeAfterRecordingDuration;

        }

        /// <summary>
        /// Gibt die aktuellen AllgemeinesTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public AllgemeinesTabEinstellungen getSettings()
        {
            AllgemeinesTabEinstellungen newSettings = new AllgemeinesTabEinstellungen();

            newSettings.AufnahmeStartKey = (Keys)Enum.Parse(typeof(Keys), bAufnhameStart.Text);
            newSettings.AufnahmeStopKey = (Keys)Enum.Parse(typeof(Keys), bAufnhameStop.Text);

            newSettings.ShowIErinerrung = switchIErinerrungen.Value;
            newSettings.Erinerrungen = tbIErinerrungen.Text;
            newSettings.ErinerrungenAnzeigeDauer = (int)nudDuration.Value;

            newSettings.ShowTimeAfterRecording = checkShowTimeAfterRecording.Value;
            newSettings.ShowTimeAfterRecordingDuration = (int)nudShowTimeAfterRecording.Value;

            return newSettings;
        }



        private void AllgemeinesTab_KeyDown(object sender, KeyEventArgs e)
        {

            if(bAufnhameStop.Text == "...")
            {
                bAufnhameStop.Text = e.KeyCode.ToString();

            }else if (bAufnhameStart.Text == "...")
            {

                bAufnhameStart.Text = e.KeyCode.ToString();

            }

        }

        private void bAufnhameStart_Click(object sender, EventArgs e)
        {

            bAufnhameStart.Text = "...";

        }
        private void bAufnhameStop_Click(object sender, EventArgs e)
        {
            bAufnhameStop.Text = "...";

        }

        private void switchIErinerrungen_OnValueChange(object sender, EventArgs e)
        {

            if(switchIErinerrungen.Value == true)
            {
                tbIErinerrungen.Enabled = true;

            }else
            {

                tbIErinerrungen.Enabled = false;

            }

        }
    }
}

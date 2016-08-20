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

            bAufnhameStart.Text = Settings.AufnahmeStartKey.ToString();
            bAufnhameStop.Text = Settings.AufnahmeStopKey.ToString();


            switchÜFenster.Value = Settings.ShowÜFenster;
            checkÜFensterTimer.Checked = Settings.ShowÜFensterTimer;
            checkÜFensterCPU.Checked = Settings.ShowÜFensterCPU;
            checkÜFensterRAM.Checked = Settings.ShowÜFensterRAM;

            switchIErinerrungen.Value = Settings.ShowIErinerrung;
            tbIErinerrungen.Text = Settings.Erinerrungen;
            nudDuration.Value = Settings.ErinerrungenAnzeigeDauer;

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

            newSettings.ShowÜFenster = switchÜFenster.Value;
            newSettings.ShowÜFensterTimer = checkÜFensterTimer.Checked;
            newSettings.ShowÜFensterCPU = checkÜFensterCPU.Checked;
            newSettings.ShowÜFensterRAM= checkÜFensterRAM.Checked;

            newSettings.ShowIErinerrung = switchIErinerrungen.Value;
            newSettings.Erinerrungen = tbIErinerrungen.Text;
            newSettings.ErinerrungenAnzeigeDauer = (int)nudDuration.Value;

            return newSettings;
        }



        private void AllgemeinesTab_KeyDown(object sender, KeyEventArgs e)
        {

            if(bAufnhameStart.Text == "...")
            {
                bAufnhameStart.Text = e.KeyCode.ToString();

            }else if (bAufnhameStop.Text == "...")
            {

                bAufnhameStop.Text = e.KeyCode.ToString();

            }

        }

        private void bAufnhameStop_Click(object sender, EventArgs e)
        {

            bAufnhameStop.Text = "...";

        }
        private void bAufnhameStart_Click(object sender, EventArgs e)
        {
            bAufnhameStart.Text = "...";

        }

        private void switchÜFenster_OnValueChange(object sender, EventArgs e)
        {

            if(switchÜFenster.Value == true)
            {
                panelÜFensterSettings.Enabled = true;

            }else
            {

                panelÜFensterSettings.Enabled = false;

            }

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

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
    public partial class Überwachung : Form
    {
        public Überwachung()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lädt die Einstellungen.
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(ÜberwachungTabEinstellungen Settings)
        {

            tbAufnahmeordner.Text = Settings.ÜberwachungOrdner;

            switchCPU.Value = Settings.ÜShowCPU;
            switchGPU.Value = Settings.ÜShowGPU;
            switchSpeicherplatz.Value = Settings.ÜShowSpeicherort;

        }

        /// <summary>
        /// Gibt die aktuellen ÜberwachungTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public ÜberwachungTabEinstellungen getSettings()
        {
            ÜberwachungTabEinstellungen newSettings = new ÜberwachungTabEinstellungen();

            newSettings.ÜberwachungOrdner = tbAufnahmeordner.Text;

            newSettings.ÜShowCPU = switchCPU.Value;
            newSettings.ÜShowGPU = switchGPU.Value;
            newSettings.ÜShowSpeicherort = switchSpeicherplatz.Value;

            return newSettings;
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {

            if(fbdAufnahmeordner.ShowDialog() == DialogResult.OK)
            {

                tbAufnahmeordner.Text = fbdAufnahmeordner.SelectedPath;

            }

        }
    }
}

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
    public partial class ProgrammeTab : Form
    {
        public ProgrammeTab()
        {
            InitializeComponent();
        }

        private void ProgrammeTab_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(ProgrammeTabEinstellungen Settings)
        {
            foreach(string item in Settings.Programme)
            {
                lbProgramme.Items.Add(item);
            }
            
        }

        /// <summary>
        /// Gibt die aktuellen ProgrammeTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public ProgrammeTabEinstellungen getSettings()
        {

            ProgrammeTabEinstellungen newSettings = new ProgrammeTabEinstellungen();

            foreach (string item in lbProgramme.Items)
            {
                newSettings.Programme.Add(item);
            }
            
            return newSettings;

        }

    }
}

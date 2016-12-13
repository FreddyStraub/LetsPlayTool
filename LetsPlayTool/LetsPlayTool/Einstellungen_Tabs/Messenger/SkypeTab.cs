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
        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        public void setSettings(SkypeSettings settings)
        {

            switchActive.Value = settings.active;

            cbStatusIA.selectedIndex = settings.statusInAufnahme;
            cbStatusNA.selectedIndex = settings.statusNachAufnahme;

            tbStatusmeldung.Text = settings.Statusmeldung;
            checkStatusMeldung.Checked = settings.writeStatusmeldung;


            if (checkStatusMeldung.Checked)
            {
                tbStatusmeldung.Enabled = true;

            }
            else
            {
                tbStatusmeldung.Enabled = false;

            }

        }

        /// <summary>
        /// Gibt die aktuellen SkypeSettings zurück
        /// </summary>
        /// <returns></returns>
        public SkypeSettings getSettings()
        {

            SkypeSettings newSks = new SkypeSettings();

            newSks.active = switchActive.Value;

            newSks.statusInAufnahme = cbStatusIA.selectedIndex;
            newSks.statusNachAufnahme = cbStatusNA.selectedIndex;

            newSks.Statusmeldung = tbStatusmeldung.Text;
            newSks.writeStatusmeldung = checkStatusMeldung.Checked;

            return newSks;
        }

        private void checkStatusMeldung_OnChange(object sender, EventArgs e)
        {

            if (checkStatusMeldung.Checked)
            {
                tbStatusmeldung.Enabled = true;
                
            }else
            {
                tbStatusmeldung.Enabled = false;
                
            }

        }

        private void checkStatusMeldung_OnChange_1(object sender, EventArgs e)
        {

            tbStatusmeldung.Enabled = checkStatusMeldung.Checked;

        }
    }
}

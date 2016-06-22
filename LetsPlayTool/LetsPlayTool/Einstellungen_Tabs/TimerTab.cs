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
    public partial class TimerTab : Form
    {
        public TimerTab()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void TimerTab_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(TimerTabEinstellungen Settings)
        {

            foreach(TimerProfil p in Settings.TimerProfiles)
            {

                lbProfiles.Items.Add(p.name);

            }


        }

        /// <summary>
        /// Gibt die aktuellen TimerTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public TimerTabEinstellungen getSettings()
        {

            TimerTabEinstellungen newSettings = new TimerTabEinstellungen();

            

            return newSettings;

        }

    }
}

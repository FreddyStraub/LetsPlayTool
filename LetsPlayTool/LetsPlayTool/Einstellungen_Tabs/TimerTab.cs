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
        
        List<TimerProfil> TimerProfiles = new List<TimerProfil>();

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(TimerTabEinstellungen Settings)
        {

            lbProfiles.Items.Clear();
            this.TimerProfiles.Clear();
            lvTimes.Items.Clear();


            foreach(TimerProfil p in Settings.TimerProfiles)
            {
                lbProfiles.Items.Add(p.name);
                TimerProfiles.Add(p);
            }

        }

        /// <summary>
        /// Gibt die aktuellen TimerTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public TimerTabEinstellungen getSettings()
        {

            TimerTabEinstellungen newSettings = new TimerTabEinstellungen();

            foreach(string item in lbProfiles.Items)
            {

                newSettings.TimerProfiles.Add(TimerProfiles[lbProfiles.Items.IndexOf(item)]);

            }

            return newSettings;

        }

        private void lbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (ListViewItem Item in TimerProfiles[lbProfiles.SelectedIndex].Times)
            {

                lvTimes.Items.Add(Item);

            }

        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void bProfilErstellen_Click(object sender, EventArgs e)
        {

            Dialogs.InputDilaog Name = new Dialogs.InputDilaog();

            if(Name.ShowDialog() == DialogResult.OK)
            {
                createTimerProfile(Name.Input);
                
            }

            updateTimerProfiles();

        }

        /// <summary>
        /// Erstellt ein neues Timerprofil.
        /// </summary>
        /// <param name="name"></param>
        private void createTimerProfile(string name)
        {

            TimerProfil t = new TimerProfil(name);
            TimerProfiles.Add(t);

        }

        /// <summary>
        /// Aktualisiert die Timerprofiles
        /// </summary>
        private void updateTimerProfiles()
        {

            lbProfiles.Items.Clear();

            foreach(TimerProfil t in TimerProfiles)
            {
                lbProfiles.Items.Add(t.name);
            }
        }

    }
}

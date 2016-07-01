using LetsPlayTool.Dialogs;
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

            lbProfiles.SelectedItem = Settings.SelectedTimerProfil;

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

                try
                {
                    newSettings.SelectedTimerProfil = lbProfiles.SelectedItem.ToString();
                }
                catch { }
            }

            return newSettings;

        }

        private void lbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTimes();
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

        /// <summary>
        /// Lädt die Zeiten des ausgewählten Timerprofils.
        /// </summary>
        private void updateTimes()
        {


            lvTimes.Items.Clear();

            if (lbProfiles.SelectedItem != null)
            {

                int index = lbProfiles.Items.IndexOf(lbProfiles.SelectedItem);

                foreach (ListViewItem Item in TimerProfiles[index].Times)
                {

                    lvTimes.Items.Add(Item);

                }


            }


        }

        private void bProfilLöschen_Click(object sender, EventArgs e)
        {

            if (lbProfiles.SelectedItems.Count != 0)
            {

                TimerProfiles.Remove(TimerProfiles[lbProfiles.Items.IndexOf(lbProfiles.SelectedItem)]);
                lbProfiles.Items.Remove(lbProfiles.SelectedItem);

            }
        }
        private void bProfilErstellen_Click(object sender, EventArgs e)
        {

            Dialogs.InputDilaog Name = new Dialogs.InputDilaog();

            if (Name.ShowDialog() == DialogResult.OK)
            {
                createTimerProfile(Name.Input);

            }

            updateTimerProfiles();

        }

        private void bZeitHinzufügen_Click(object sender, EventArgs e)
        {

            if(lbProfiles.SelectedItem != null)
            {
                TimeDilaog TD = new TimeDilaog();
                TD.ShowDialog();

                if (TD.DialogResult == DialogResult.OK)
                {

                    ListViewItem Time = new ListViewItem();
                    Time.Font = new Font(Time.Font.Name, 24f, FontStyle.Regular);
                    Time.BackColor = TD.Farbe;
                    Time.ForeColor = Color.White;

                    string TimeText = "";

                    #region Anzeige


                    //Stunden
                    if (TD.Stunden < 10)
                    {
                        TimeText += "0" + TD.Stunden.ToString() + ":";

                    }
                    else
                    {
                        TimeText += TD.Stunden.ToString() + ":";
                    }

                    //Minuten
                    if (TD.Minuten < 10)
                    {
                        TimeText += "0" + TD.Minuten.ToString() + ":";

                    }
                    else
                    {
                        TimeText += TD.Minuten.ToString() + ":";
                    }

                    //Sekunden
                    if (TD.Sekunden < 10)
                    {
                        TimeText += "0" + TD.Sekunden.ToString() + ":";

                    }
                    else
                    {
                        TimeText += TD.Sekunden.ToString() + ":";
                    }

                    //Millisekunden
                    if (TD.Millisekunden < 10)
                    {
                        TimeText += "0" + TD.Millisekunden.ToString();

                    }
                    else
                    {
                        TimeText += TD.Millisekunden.ToString();
                    }

                    #endregion

                    Time.Text = TimeText;

                    TimerProfiles[lbProfiles.Items.IndexOf(lbProfiles.SelectedItem)].Times.Add(Time);

                }
            }

            updateTimes();

        }
        private void bZeitEntfernen_Click(object sender, EventArgs e)
        {

            if(lvTimes.SelectedItems.Count != 0)
            {

               // TimerProfiles[lbProfiles.Items.IndexOf(lbProfiles.SelectedItem)]Times.Remove(lvTimes.SelectedItems);

                foreach(ListViewItem Item in lvTimes.SelectedItems)
                {
                    int TimerProfil = lbProfiles.Items.IndexOf(lbProfiles.SelectedItem);

                    TimerProfiles[TimerProfil].Times.Remove(Item);

                }


            }

            updateTimes();

        }
    }
}

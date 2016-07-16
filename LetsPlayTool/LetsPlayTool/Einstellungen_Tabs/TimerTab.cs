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

            lbProfiles.SelectedIndex = 0;

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

            updateTimes();
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

                foreach (Time time in TimerProfiles[index].Times)
                {

                    lvTimes.Items.Add(time.ListViewItem);

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

                    ListViewItem TimeItem = new ListViewItem();
                    TimeItem.Font = new Font(TimeItem.Font.Name, 24f, FontStyle.Regular);
                    TimeItem.BackColor = TD.Farbe;
                    TimeItem.ForeColor = Color.White;


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

                    TimeItem.Text = TimeText;

                    Time t = new Time(TimeItem);
                    t.isBig = TD.isBig;
                    t.Text = TD.TimerText;

                    TimerProfiles[lbProfiles.Items.IndexOf(lbProfiles.SelectedItem)].Times.Add(t);

                }
            }

            updateTimes();

        }
        private void bZeitEntfernen_Click(object sender, EventArgs e)
        {

            if(lvTimes.SelectedItems.Count != 0)
            {
                foreach(ListViewItem Item in lvTimes.SelectedItems)
                {
                    int TimerProfil = lbProfiles.Items.IndexOf(lbProfiles.SelectedItem);

                    int realIndex = lvTimes.Items.IndexOf(Item);


                    TimerProfiles[TimerProfil].Times.Remove(TimerProfiles[TimerProfil].Times[realIndex]);

                }


            }

            updateTimes();

        }


        private void lvTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvTimes.SelectedItems.Count != 0)
            {

                int TimerProfilIndex = lbProfiles.Items.IndexOf(lbProfiles.SelectedItem); //Ausgewähltes TimerProfil
                int realIndex = lvTimes.Items.IndexOf(lvTimes.SelectedItems[0]); //Index des ListViewItems (ausgewählten)

                string realText = TimerProfiles[TimerProfilIndex].Times[realIndex].Text; //Text der ausgewählten Zeit


                if (realText != String.Empty & realText != null)
                {
                    gbText.Visible = true;
                    richTextBox1.Text = realText;

                }
                else
                {
                    richTextBox1.Text = "";
                    gbText.Visible = false;
                    
                }

            }
            else
            {
                richTextBox1.Text = "";
                gbText.Visible = false;

            }

        }
        }
}

using LetsPlayTool.Einstellungen_Tabs.Messenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

      //  public ÜberwachungTabEinstellungen überwachungTagEinstellungen = new ÜberwachungTabEinstellungen();

        /// <summary>
        /// Lädt die Einstellungen.
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(ÜberwachungTabEinstellungen Settings)
        {

            tbAufnahmeordner.Text = Settings.ÜberwachungOrdner;

            switchCPU.Value = Settings.ÜShowCPU;
            switchRAM.Value = Settings.ÜShowRAM;

          //  überwachungTagEinstellungen = Settings;

            setMessengerSettigs(Settings.MessengerSettings);
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
            newSettings.ÜShowRAM = switchRAM.Value;

            getMessengerSettings();

            newSettings.MessengerSettings = getMessengerSettings();

            return newSettings;
        }

        /// <summary>
        /// Speichert die Messenger-Einstellungen.
        /// </summary>
        private Messenger.Settings getMessengerSettings()
        {
            Messenger.Settings newMSettings = new Messenger.Settings();

            newMSettings.skypeSettings = sk.getSettings();

            return newMSettings;

        }
        private void setMessengerSettigs(Messenger.Settings mSettings)
        {

            sk.setSettings(mSettings.skypeSettings);

        }


        private void bBrowse_Click(object sender, EventArgs e)
        {

            if(fbdAufnahmeordner.ShowDialog() == DialogResult.OK)
            {


                if (fbdAufnahmeordner.SelectedPath.Length > 40)
                {
                    int startIndex = fbdAufnahmeordner.SelectedPath.Length - 40;
                    tbAufnahmeordner.Text = "... " + fbdAufnahmeordner.SelectedPath.Substring(startIndex);
                }
                else
                {
                    tbAufnahmeordner.Text = fbdAufnahmeordner.SelectedPath;

                }

                
            }

        }
        private void tbAufnahmeordner_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

                try { Process.Start(tbAufnahmeordner.Text); } catch { }

            }
        }
        private void bBrowse_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                try { Process.Start(tbAufnahmeordner.Text); } catch { }

        }

        //Messenger


        SkypeTab sk = new SkypeTab();

        private void toggleMessenger(int number)
        {
            getMessengerSettings();
            switch (number)
            {

                case 0:

                  //  bTimer.selected = true;

                    #region Tab anzeigen

                    sk.TopLevel = false;
                    sk.AutoScroll = true;
                    
                    sk.setSettings(getMessengerSettings().skypeSettings);

                    panelMessengerSwitch.Controls.Add(sk);
                    sk.Show();

                    #endregion

                    break;

            }

            }

        private void bSkype_Click(object sender, EventArgs e)
        {
            toggleMessenger(0);

            
        }

        private void panelMessengerSwitch_ControlAdded(object sender, ControlEventArgs e)
        {
            panelMessengerSwitch.Visible = false;
            panelAnimator.Show(panelMessengerSwitch);
        }
    }
}

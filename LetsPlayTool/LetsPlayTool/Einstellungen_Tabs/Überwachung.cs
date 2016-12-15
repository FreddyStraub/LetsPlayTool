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
                checkAufnahmeOrdnerÖffnen.Checked = Settings.OpenÜberwachungOrdner;


                switchÜFenster.Value = Settings.ShowÜFenster;
                checkÜFensterTimer.Checked = Settings.ShowÜFensterTimer;
                checkÜFensterCPU.Checked = Settings.ShowÜFensterCPU;
                checkÜFensterRAM.Checked = Settings.ShowÜFensterRAM;

                checkSkype.Checked = Settings.ShowSkype;
                checkTeamspeal.Checked = Settings.ShowTeamspeak;
                checkDiscord.Checked = Settings.ShowDiscord;
                checkMailclient.Checked = Settings.ShowMail;
                checkSteam.Checked = Settings.ShowSteam;


        }

        /// <summary>
        /// Gibt die aktuellen ÜberwachungTab Einstellungen zurück
        /// </summary>
        /// <returns></returns>
        public ÜberwachungTabEinstellungen getSettings()
        {
            ÜberwachungTabEinstellungen newSettings = new ÜberwachungTabEinstellungen();

            newSettings.ÜberwachungOrdner = tbAufnahmeordner.Text;
            newSettings.OpenÜberwachungOrdner = checkAufnahmeOrdnerÖffnen.Checked;

            newSettings.ShowÜFenster = switchÜFenster.Value;
            newSettings.ShowÜFensterTimer = checkÜFensterTimer.Checked;
            newSettings.ShowÜFensterCPU = checkÜFensterCPU.Checked;
            newSettings.ShowÜFensterRAM = checkÜFensterRAM.Checked;


            newSettings.ÜShowCPU = switchCPU.Value;
            newSettings.ÜShowRAM = switchRAM.Value;

            newSettings.ShowSkype = checkSkype.Checked;
            newSettings.ShowTeamspeak = checkTeamspeal.Checked;
            newSettings.ShowDiscord = checkDiscord.Checked;
            newSettings.ShowMail = checkMailclient.Checked;
            newSettings.ShowSteam = checkSteam.Checked;


            return newSettings;
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

        private void switchÜFenster_OnValueChange(object sender, EventArgs e)
        {

            if (switchÜFenster.Value == true)
            {
                panelÜFensterSettings.Enabled = true;

            }
            else
            {

                panelÜFensterSettings.Enabled = false;

            }

        }
    }
}

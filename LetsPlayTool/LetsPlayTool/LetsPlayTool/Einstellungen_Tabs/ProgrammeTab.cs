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

        /// <summary>
        /// Lädt die Einstellungen
        /// </summary>
        /// <param name="Settings"></param>
        public void setSettings(ProgrammeTabEinstellungen Settings)
        {
            lbProgramme.Items.Clear();

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
        
        private void bHinzufügen_Click(object sender, EventArgs e)
        {
            programmeHinzufügen();
        }
        private void bEntfernen_Click(object sender, EventArgs e)
        {
            programmeEntfernen();
        }

        /// <summary>
        /// Lässt den User Programme zur Liste hinzufügen.
        /// </summary>
        public void programmeHinzufügen()
        {

            if(opfHinzufügen.ShowDialog() == DialogResult.OK)
            {

                foreach(string programm in opfHinzufügen.FileNames)
                {
                    if (lbProgramme.Items.IndexOf(programm) == -1)
                    {

                        lbProgramme.Items.Add(programm);

                    }
                    else
                    {

                        MessageBox.Show("Dieses Programm ist bereits in der Liste!", "Programm bereits in Liste", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }

            }

        }

        /// <summary>
        /// Läst den User Programme von der Liste entfernen.
        /// </summary>
        private void programmeEntfernen()
        {
            if(lbProgramme.SelectedItems.Count != 0)
            {

                while(lbProgramme.SelectedItems.Count != 0)
                {

                    lbProgramme.Items.Remove(lbProgramme.SelectedItems[0]);

                }

            }


        }


    }
}

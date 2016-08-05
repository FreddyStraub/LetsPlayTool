using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs
{
    [Serializable]
    public class ProgrammeTabEinstellungen
    {

        public List<string> Programme = new List<string>();

        //Startet die Programme
        public void startProgramms()
        {

            foreach (string programm in this.Programme)
            {
                try {

                    Process.Start(programm);

                }
                catch
                {

                    MessageBox.Show(programm + " konnte nicht ausgeführt werden! Überprüfen sie bitte den Pfad!", "LetsPlayTool - File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

        }


    }
    
}

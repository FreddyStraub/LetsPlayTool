using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Process.Start(programm);
            }

        }


    }
    
}

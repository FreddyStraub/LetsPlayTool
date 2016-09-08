using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Session
{
    public class SÜberwachung
    {
        public SÜberwachung(string DirectoryPath)
        {

            Userpath = DirectoryPath;

        }


        public static string Userpath { get; private set; } 

        System.IO.DriveInfo[] Drives = System.IO.DriveInfo.GetDrives(); // alle Laufwerke auslesen

        string drive = "";
        public long freierSpeicherMB = 0;
        public long belegterSpeicherMB = 0;
        public long freierSpeicherGB = 0;
        public long belegterSpeicherGB = 0;

        /// <summary>
        /// Setzt: freierSpeicherMB, belegterSpeicherMB, freierSpeicherGB,belegterSpeicherGB mit den Systemwerten.
        /// </summary>
        public void generateMemoryValues()
        {
            drive = System.IO.Path.GetPathRoot(Userpath); // = Das laufwerk welches im Userpath steht.

            foreach (System.IO.DriveInfo d in Drives)
            {
                if (d.Name == drive)
                {

                    freierSpeicherMB = d.TotalFreeSpace / (1024 * 1024);
                    belegterSpeicherMB = d.TotalSize / (1024 * 1024) - freierSpeicherMB;

                    freierSpeicherGB = d.TotalFreeSpace / (1024 * 1024 * 1024);
                    belegterSpeicherGB = d.TotalSize / (1024 * 1024 * 1024) - freierSpeicherGB;
                }
            }
        }

    }
}

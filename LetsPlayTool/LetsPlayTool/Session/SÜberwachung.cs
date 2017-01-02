using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LetsPlayTool.Session
{
    public class SÜberwachung
    {
        public SÜberwachung(string DirectoryPath)
        {

            Userpath = DirectoryPath;
            InitialisierePerformanceCounter();

        }


        public static string Userpath { get; private set; } 

        System.IO.DriveInfo[] Drives = System.IO.DriveInfo.GetDrives(); // alle Laufwerke auslesen

        string drive = "";
        public long freierSpeicherMB = 0;
        public long belegterSpeicherMB = 0;
        public long freierSpeicherGB = 0;
        public long belegterSpeicherGB = 0;

        public float USpeed, DSpeed;

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


        static PerformanceCounter cpuCounter; // globaler PerformanceCounter 
        static PerformanceCounter RAMCounter;

        static PerformanceCounter performanceCounterReceived; //Down - Stream
        static PerformanceCounter performanceCounterSent;   //UP - Stream
        static PerformanceCounterCategory performanceCounterCategory = new PerformanceCounterCategory("Network Interface");



        public int cpuAuslastung = 0;
        public int freierRAM = 0;


        /// <summary>
        /// Setzt: cpuAUslastung, freierRAM
        /// </summary>
        public void generatePerformanceCounterValues()
        {

            cpuAuslastung = (int)cpuCounter.NextValue();
            freierRAM = (int)RAMCounter.NextValue();

            DSpeed = (performanceCounterReceived.NextValue() / 1000);
            USpeed = (performanceCounterSent.NextValue() / 1000);




        }

        /// <summary>
        /// INitialisiert den Performencecounter für CPU
        /// </summary>
        static void InitialisierePerformanceCounter()
        {
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            RAMCounter = new PerformanceCounter();
            RAMCounter.CategoryName = "Memory";
            RAMCounter.CounterName = "Available MBytes";



            string instance = performanceCounterCategory.GetInstanceNames()[0];

            performanceCounterSent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", instance);
            performanceCounterReceived = new PerformanceCounter("Network Interface", "Bytes Received/sec", instance);




        }  // "_Total" entspricht der gesamten CPU Auslastung, Bei Computern mit mehr als 1 logischem Prozessor: "0" dem ersten Core, "1" dem zweiten...


    }
}

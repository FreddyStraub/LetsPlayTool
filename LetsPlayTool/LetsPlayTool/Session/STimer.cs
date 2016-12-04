using LetsPlayTool.Dialogs;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LetsPlayTool.Session
{
    public class STimer
    {

        public TimerProfil selectedTimerProfil;


        public STimer(TimerProfil selectedTimerProfil)
        {

            this.selectedTimerProfil = selectedTimerProfil;

        }

        public string TimeString = "";

        public int Stunden { get; private set; }
        public int Minuten { get; private set; }
        public int Sekunden { get; private set; }
        public int Millisekunden { get; private set; }

        public long hours { get; set; }
        public long minutes { get; set; }
        public long seconds { get; set; }
        public long milliseconds { get; set; }

        public Stopwatch st = new Stopwatch();
        
        

        public void generateTimeString()
    {
            milliseconds = st.ElapsedMilliseconds;

            TimeSpan ElapsedTime = st.Elapsed;

            #region aussehen

            string StringStunden = "";
            string StringMinuten = "";
            string StringSekunden = "";
            string StringMillisekunden = "";

            //ElapsedTime.Hours
            if (ElapsedTime.Hours < 10)
            {
                StringStunden = "0" + ElapsedTime.Hours.ToString();
            }
            else
            {
                StringStunden = ElapsedTime.Hours.ToString();
            }

            //ElapsedTime.Minutes
            if (ElapsedTime.Minutes < 10)
            {
                StringMinuten = "0" + ElapsedTime.Minutes.ToString();
            }
            else
            {
                StringMinuten = ElapsedTime.Minutes.ToString();
            }

            //ElapsedTime.Seconds
            if (ElapsedTime.Seconds < 10)
            {
                StringSekunden = "0" + ElapsedTime.Seconds.ToString();
            }
            else
            {
                StringSekunden = ElapsedTime.Seconds.ToString();
            }

            //ElapsedTime.Milliseconds
            if (ElapsedTime.Milliseconds > 0 & ElapsedTime.Milliseconds < 10)
            {
                StringMillisekunden = "00" + ElapsedTime.Milliseconds.ToString();
            }
            else if (ElapsedTime.Milliseconds > 9 & ElapsedTime.Milliseconds < 100)
            {
                StringMillisekunden = "0" + ElapsedTime.Milliseconds.ToString();

            }
            else
            {
                StringMillisekunden = ElapsedTime.Milliseconds.ToString();
                
            }

            try
            {
                StringMillisekunden = StringMillisekunden.Substring(0, 2);

            }
            catch { }


            #endregion



            TimeString = StringStunden + ":"  + StringMinuten + ":" + StringSekunden + ":" + StringMillisekunden;





        }

        /// <summary>
        /// Listet die Zeiten des aktuellen TimerProfiles auf.
        /// </summary>
        /// <returns></returns>
        public List<Time> getTimes()
        {

            List<Time> Times = new List<Time>();

            foreach (Time t in selectedTimerProfil.Times)
            {
                Times.Add(t);
            }

            return Times;
        }


    }
}
using LetsPlayTool.Dialogs;
using System.Collections.Generic;

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

        public void generateTimeString()
    {

            #region Time

            Millisekunden += 1;

            if (Millisekunden == 65)
            {
                Sekunden += 1;
                Millisekunden = 0;
            }

            if (Sekunden == 60)
            {
                Minuten += 1;
                Sekunden = 0;
            }

            if (Minuten == 60)
            {
                Stunden += 1;
                Minuten = 0;
            }


            #region aussehen

            string StringStunden = "";
            string StringMinuten = "";
            string StringSekunden = "";
            string StringMillisekunden = "";

            //Stunden
            if (Stunden < 10)
            {
                StringStunden = "0" + Stunden.ToString();
            }
            else
            {
                StringStunden = Stunden.ToString();
            }

            //Minuten
            if (Minuten < 10)
            {
                StringMinuten = "0" + Minuten.ToString();
            }
            else
            {
                StringMinuten = Minuten.ToString();
            }

            //Sekunden
            if (Sekunden < 10)
            {
                StringSekunden = "0" + Sekunden.ToString();
            }
            else
            {
                StringSekunden = Sekunden.ToString();
            }

            //Millisekunden
            if (Millisekunden < 10)
            {
                StringMillisekunden = "0" + Millisekunden.ToString();
            }
            else
            {
                StringMillisekunden = Millisekunden.ToString();
            }


            #endregion

            TimeString = StringStunden + ":" + StringMinuten + ":" + StringSekunden + ":" + StringMillisekunden;

            #endregion // Mácht das der Timer 


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
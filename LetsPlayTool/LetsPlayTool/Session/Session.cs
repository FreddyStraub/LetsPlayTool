using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Session
{
    public class Session
    {

        Einstellungen einstellungen;

        public STimer Timer;
        public SÜberwachung Überwachung;

        public Session(TimerProfil selectedTimerProfil, Einstellungen einstellungen)
        {
            Timer = new STimer(selectedTimerProfil);
            Überwachung = new SÜberwachung(einstellungen.Überwachung.ÜberwachungOrdner);

            this.einstellungen = einstellungen;
        }


        public void Next()
        {
                        
            Timer.generateTimeString();
            Überwachung.generateMemoryValues();
            Überwachung.generatePerformanceCounterValues();
        }



    }
}

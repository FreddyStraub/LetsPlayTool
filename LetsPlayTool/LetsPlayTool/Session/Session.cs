using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Session
{
    public class Session
    {

        //  public TimerProfil selectedTimerProfil;

        public STimer Timer;

        public Session(TimerProfil selectedTimerProfil)
        {
            Timer = new STimer(selectedTimerProfil);
        }



        public void Next()
        {

            Timer.generateTimeString();

        }

    }
}

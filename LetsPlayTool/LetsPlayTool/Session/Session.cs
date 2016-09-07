using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Session
{
    public class Session
    {

        public STimer Timer = new STimer();

        public void Next()
        {

            Timer.generateTimeString();

        }

    }
}

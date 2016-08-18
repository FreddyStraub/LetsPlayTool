﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs
{
    [Serializable]
    public class AllgemeinesTabEinstellungen
    {

        public Keys AufnahmeStartKey;
        public Keys AufnahmeStopKey;

        public bool ShowÜFenster;
        public bool ShowÜFensterTimer;
        public bool ShowÜFensterCPU;
        public bool ShowÜFensterRAM;

        public bool ShowIErinerrung;

        public string Erinerrungen;


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Dialogs
{
    [Serializable]
    public class Time
    {

        public string Text { get; set; }

        public ListViewItem ListViewItem { get; set; }

        [NonSerialized] public Stopwatch stopwatch;

        public bool isLoop { get; set; }

        public int Stunden { get; set; }
        public int Minuten { get; set; }
        public int Sekunden { get; set; }
        public int Millisekunden { get; set; }



        public Time(ListViewItem Item)
        {

            ListViewItem = Item;


        }

    }
}

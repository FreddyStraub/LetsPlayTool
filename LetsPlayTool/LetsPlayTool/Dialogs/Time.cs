using System;
using System.Collections.Generic;
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
        public bool isBig { get; set; }

        public ListViewItem ListViewItem { get; set; }

        public Time(ListViewItem Item)
        {

            ListViewItem = Item;


        }

    }
}

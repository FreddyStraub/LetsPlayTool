using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    [Serializable]
    public class TimerProfil
    {

        public string name { get; set; }
        public List<ListViewItem> Times = new List<ListViewItem>();
        
        public TimerProfil(string name)
        {

            this.name = name;

        }



    }
}

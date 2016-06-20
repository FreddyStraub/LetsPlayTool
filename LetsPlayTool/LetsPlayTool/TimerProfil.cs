using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    public class TimerProfil
    {

        public string name { get; set; }
        public List<ListViewItem> Times;
        
        public TimerProfil(string name)
        {

            this.name = name;

        }



    }
}

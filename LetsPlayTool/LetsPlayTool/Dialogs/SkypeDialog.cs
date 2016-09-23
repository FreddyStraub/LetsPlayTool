using SKYPE4COMLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Dialogs
{
    public partial class SkypeDialog : Form
    {

        Skype _SkypeClient;

        public bool zugriffErlauben { get; private set; }

        public SkypeDialog(Skype skypeclient)
        {
            InitializeComponent();
            _SkypeClient = skypeclient;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            zugriffErlauben = true;
            Close();
        }

        private void SkypeDialog_Validated(object sender, EventArgs e)
        {
            _SkypeClient.Attach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            zugriffErlauben = false;
            Close();
        }
    }
}

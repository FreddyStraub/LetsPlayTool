using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.LetsPlayToolMessage
{
    public partial class Big : Form
    {

        public int duration { get; private set; }

        public Big(string Message, int duration)
        {
            InitializeComponent();

            Text = Message;
            this.duration = duration;

            button1.Text = Text;
        }



        int progressTime = 0;
        private void ShowMessage_Tick(object sender, EventArgs e)
        {

            progressTime++;

            if (progressTime == duration)
            {

                ShowMessageAnimator.HideSync(button1);
                Close();
            }

            if (button1.Visible == false)
                Close();
        }

        private void Big_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            ShowMessageAnimator.Show(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

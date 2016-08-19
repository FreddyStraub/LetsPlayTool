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
    public partial class ÜFenster : Form
    {
        public ÜFenster(string message, int duration, Color color)
        {
            InitializeComponent();
            button1.Text = message;

            button1.Visible = false;
            ShowMessageAnimator.Show(button1);

            button1.BackColor = color;

            this.duration = duration;

        }

        public int duration { get; private set; }

        int progressTime = 0;
        private void ShowMessage_Tick(object sender, EventArgs e)
        {

            progressTime++;

            if (progressTime == duration)
            {

                ShowMessageAnimator.HideSync(button1);
                Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

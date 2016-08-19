using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.LetsPlayToolMessage
{
    public partial class Small : Form
    {
        public Small(string Text)
        {
            InitializeComponent();

            this.Text = Text;
            button1.Text = Text;


            #region Textgröße anpassen

            if (Text.Length > 77 && Text.Length < 150)
            {
                button1.Font = new Font(Font.Name, 18f, FontStyle.Regular);

            }
            else if (Text.Length > 150)
            {
                button1.Font = new Font(Font.Name, 14f, FontStyle.Regular);
            }

            #endregion



        }
        public Small(string Text, Color backColor)
        {
            InitializeComponent();

            this.Text = Text;
            button1.Text = Text;

            #region Textgröße anpassen

            if(Text.Length > 77 && Text.Length < 150)
            {
                button1.Font = new Font(Font.Name, 18f, FontStyle.Regular);

            }else if (Text.Length > 150)
            {
                button1.Font = new Font(Font.Name, 14f, FontStyle.Regular);
            }

            #endregion

            button1.BackColor = backColor;

        }

        private void Small_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            ShowMessageAnimator.Show(button1);

        }


        int progressTime = 0;
        private void ShowMessage_Tick(object sender, EventArgs e)
        {

            progressTime++;

            if(progressTime ==3)
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

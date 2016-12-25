using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorialClasses;

namespace LetsPlayTool.Tutorial
{
    public partial class frmTutorials : Form
    {

        public TutorialClasses.Tutorial tutorial;

        
        int cardindex = 0;

        int pictureCount;

        public frmTutorials(TutorialClasses.Tutorial tutorial)
        {
            InitializeComponent();
            this.tutorial = tutorial;

            lbTitle.Text = tutorial.title;

            loadCard(tutorial.Cards[0]);

            

        }

        private void loadCard(TutorialCard Card)
        {

            lbCardTitle.Text = Card.titel;
            pictureBox1.Image = Card.picture;
            richTextBox1.Text = Card.discription;

        }

        #region Move Form

        private Point mouseposition;

        private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseposition.X, mouseposition.Y);
                Location = mousePos;
            }
        }

        private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposition = new Point(-e.X, -e.Y);
        }

        #endregion

        #region general Animations

        /// <summary>
        /// Minimaize Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimaizeAnimation_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity - 0.1;

            if (Opacity == 0)
            {
                MinimaizeAnimation.Stop();
                Close();

            }
        }

        /// <summary>
        /// Maximaize Animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximaizeAnimation_Tick(object sender, EventArgs e)
        {


            WindowState = FormWindowState.Normal;


            if (Opacity == 1)
            {
                MaximaizeAnimation.Stop();

            }
            else
            {
                Opacity = Opacity + 0.1;

            }

        }



        #endregion

        string pfad = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool\\Tutorials\\";


        private void frmTutorials_Load(object sender, EventArgs e)
        {

            Opacity = 0; 
            MaximaizeAnimation.Start();

            lbCardTitle.Select();

            if(System.IO.Directory.Exists(pfad + "Pictures"))
                System.IO.Directory.Delete(pfad + "Pictures", true);

            System.IO.Directory.CreateDirectory(pfad + "Pictures");

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MinimaizeAnimation.Start();

        }

        private void bWeiter_Click(object sender, EventArgs e)
        {

            cardindex++;

            try
            {

                loadCard(tutorial.Cards[cardindex]);

            }
            catch
            {

                Close();

            }

        }

        private void bZurück_Click(object sender, EventArgs e)
        {

            cardindex--;

            if (cardindex > 0)
            {

                loadCard(tutorial.Cards[cardindex]);
            }
            else
            {


                cardindex = 0;
                loadCard(tutorial.Cards[cardindex]);

            }

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureCount++;

            pictureBox1.Image.Save(pfad + "Pictures\\Show " + pictureCount + ".png");
            Process.Start(pfad + "Pictures\\Show " + pictureCount + ".png");
        }

        private void frmTutorials_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.Directory.Delete(pfad + "Pictures", true);

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

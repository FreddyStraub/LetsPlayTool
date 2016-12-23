using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutorialClasses;

namespace LetsPlayToolTutorialBuilder
{
    public partial class CreateCard : Form
    {
        
        public TutorialCard tc = new TutorialCard();

        public CreateCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tc.titel = textBox1.Text;
            tc.discription = richTextBox1.Text;

            tc.picture = (Bitmap)pictureBox1.Image;


            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);


            }

        }
    }
}

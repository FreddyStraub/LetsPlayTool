using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayToolTutorialBuilder
{
    public partial class frmList : Form
    {
        public TutorialClasses.Tutorial tutorial { get; set; }

        public frmList(TutorialClasses.Tutorial tedit)
        {
            InitializeComponent();

            tutorial = tedit;
        }

        private void frmList_Load(object sender, EventArgs e)
        {

            foreach(TutorialClasses.TutorialCard tc in tutorial.Cards)
            {

                listBox1.Items.Add(tc.titel);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TutorialClasses.TutorialCard selectedTUTCard = tutorial.Cards[listBox1.SelectedIndex];


            CreateCard cc = new CreateCard();

            cc.textBox1.Text = selectedTUTCard.titel;
            cc.richTextBox1.Text = selectedTUTCard.discription;

            cc.pictureBox1.Image = selectedTUTCard.picture;


            cc.ShowDialog();


            selectedTUTCard.titel = cc.textBox1.Text;
            selectedTUTCard.discription = cc.richTextBox1.Text;
            selectedTUTCard.picture = (Bitmap)cc.pictureBox1.Image;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

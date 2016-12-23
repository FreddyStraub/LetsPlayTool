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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Tutorial t = new Tutorial();
            
        private void button1_Click(object sender, EventArgs e)
        {

            CreateCard cc = new CreateCard();
            cc.ShowDialog();


            t.Cards.Add(cc.tc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.title = textBox1.Text;

            t.save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            Close();

        }
    }
}

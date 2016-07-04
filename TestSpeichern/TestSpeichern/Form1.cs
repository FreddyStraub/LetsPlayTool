using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSpeichern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Userdaten US = new Userdaten();

            US.name = textBox1.Text;
            US.alter = (int)numericUpDown1.Value;

            US.save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Userdaten2.txt");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Userdaten US = new Userdaten();

            US = US.load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Userdaten2.txt");

            textBox1.Text = US.name;
            numericUpDown1.Value = US.alter;


        }
    }
}

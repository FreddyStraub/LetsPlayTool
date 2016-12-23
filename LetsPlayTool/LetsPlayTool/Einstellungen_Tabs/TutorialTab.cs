using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Einstellungen_Tabs
{
    public partial class TutorialTab : Form
    {
        public TutorialTab()
        {
            InitializeComponent();
        }

        private void TutorialTab_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

           TutorialClasses.Tutorial t = new TutorialClasses.Tutorial();

            string pfad = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            t = t.load(pfad + "\\TEST.tut");

            Tutorial.frmTutorials frmt = new Tutorial.frmTutorials(t);
            frmt.ShowDialog();

        }
    }
}

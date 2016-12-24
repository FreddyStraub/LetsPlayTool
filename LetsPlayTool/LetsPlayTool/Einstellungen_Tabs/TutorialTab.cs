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


        private void lbHerDamit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSd8o5AHUYxt0CoGauHqmO8vNguiJ1yiIKYyPbpB3EQIbqPtnQ/viewform");
        }

        private void lbYT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=WrO4m4dm8_U&t=1s");
        }

        private void bÜbersicht_Click(object sender, EventArgs e)
        {
            TutorialClasses.Tutorial t = new TutorialClasses.Tutorial();

            string pfad = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            t = t.load("Tutorials\\Übersicht.tut");

            Tutorial.frmTutorials frmt = new Tutorial.frmTutorials(t);
            frmt.ShowDialog();
        }

        private void bEinstellungen_Click(object sender, EventArgs e)
        {
            TutorialClasses.Tutorial t = new TutorialClasses.Tutorial();

            string pfad = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            t = t.load("Tutorials\\Einstellungen.tut");

            Tutorial.frmTutorials frmt = new Tutorial.frmTutorials(t);
            frmt.ShowDialog();

        }
    }
}

using LetsPlayTool.Update;
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
    public partial class InfoTab : Form
    {
        public InfoTab()
        {
            InitializeComponent();
        }

        private void lbWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.wolf066lp.de/letsplaytool.html");
        }

        private void lbEnwtickler_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.wolf066lp.de");

        }

        private void bSeaarchForUpdate_Click(object sender, EventArgs e)
        {
            Updater updater = new Updater();

            if (updater.UpdateAvailable())
            {

                updater.update();

            }else
            {

                MessageBox.Show("Das Tool ist auf dem neusten Stand!", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void lbFormular_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSd8o5AHUYxt0CoGauHqmO8vNguiJ1yiIKYyPbpB3EQIbqPtnQ/viewform");

        }

        private void InfoTab_Load(object sender, EventArgs e)
        {

            lbVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); //Version laden

        }
    }
}

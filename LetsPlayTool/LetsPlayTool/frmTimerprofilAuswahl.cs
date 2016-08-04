using LetsPlayTool.Einstellungen_Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool
{
    public partial class frmTimerprofilAuswahl : Form
    {
        public frmTimerprofilAuswahl(Einstellungen settings)
        {
            InitializeComponent();
            loadProfiles(settings.Timer);

        }

        public TimerProfil selectedProfil { get; private set; }
        public List<TimerProfil> TimerProfiles = new List<TimerProfil>();


        /// <summary>
        /// Lädt die Timerprofile in den Listview.
        /// </summary>
        /// <param name="Settings"></param>
        private void loadProfiles(TimerTabEinstellungen Settings)
        {

            listView1.Items.Clear();
            foreach(TimerProfil tp in Settings.TimerProfiles)
            {
           //     listView1.Items.Add(new ListViewItem(tp.name));

                ListViewItem TimeItem = new ListViewItem();
                TimeItem.Font = new Font(TimeItem.Font.Name, 20f, FontStyle.Regular);
                TimeItem.ForeColor = Color.White;
                TimeItem.Text = tp.name;

                TimerProfiles.Add(tp);

                listView1.Items.Add(TimeItem);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);

            selectedProfil = TimerProfiles[index];

            Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

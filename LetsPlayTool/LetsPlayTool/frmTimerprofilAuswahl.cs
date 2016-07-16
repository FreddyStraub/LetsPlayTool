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

        public string selectedProfil { get; private set; }

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

                listView1.Items.Add(TimeItem);

            }

            setListViewDesign();

        }

        /// <summary>
        /// Macht den die ListviewItems anschaulicher
        /// </summary>
        private void setListViewDesign()
        {

            

            for (int i = 0; i < listView1.Items.Count; i++)
            {

                listView1.Columns[0].TextAlign = HorizontalAlignment.Center;

                if (i % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.FromArgb(40, 40, 40);

                }else
                {
                    listView1.Items[i].BackColor = Color.FromArgb(0,0,0);

                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedProfil = listView1.SelectedItems[0].ToString();

            Close();
        }

        private void frmTimerprofilAuswahl_Load(object sender, EventArgs e)
        {


        }
    }
}

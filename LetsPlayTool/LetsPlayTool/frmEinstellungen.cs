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
    public partial class frmEinstellungen : Form
    {

        Einstellungen einstellungen;
        
        public frmEinstellungen()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            getAllSettings();

            Einstellungen oldSettings = new Einstellungen();
            oldSettings = oldSettings.load();

            if(!oldSettings.Equals(einstellungen) == true)
            {

                DialogResult MSG = MessageBox.Show("Änderungen speichern?", "LetsPlayTool, Änderungen speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(MSG != DialogResult.Yes)
                {

                    einstellungen.save();
                    Closeanimation.Start();

                }
                else if(MSG == DialogResult.No)
                {

                    Closeanimation.Start();


                }
                else
                {
                    DialogResult = DialogResult.None;

                }


            }
            else
            {
                Closeanimation.Start();

            }
            
        }

        private void frmEinstellungen_Load(object sender, EventArgs e)
        {
            einstellungen = new Einstellungen();

            Opacity = 0;
            Showanimation.Start();

            einstellungen = einstellungen.load(); //Lädt die Einstellungen.
            SetAllSettings(); //Setzt die geladen Einstellungen in den Tabs.


            toggle(2);
        }

        /// <summary>
        /// Lädt die gespeicherten Einstellungen der Settings-datei.
        /// </summary>
        private void SetAllSettings()
        {
            at.setSettings(einstellungen.Allgemeines);
            mt.setSettings(einstellungen.Marker);
            pt.setSettings(einstellungen.Programme);
            tt.setSettings(einstellungen.Timer);
            üt.setSettings(einstellungen.Überwachung);

        }

        /// <summary>
        /// Speichert die Eingestellten Dateien komplett.
        /// </summary>
        private void getAllSettings()
        {

            einstellungen.Allgemeines = at.getSettings();
            einstellungen.Marker = mt.getSettings();
            einstellungen.Programme = pt.getSettings();
            einstellungen.Timer = tt.getSettings();
            einstellungen.Überwachung = üt.getSettings();


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

        #region General Animations

        private void Showanimation_Tick(object sender, EventArgs e)
        {


            WindowState = FormWindowState.Normal;
            
            if (Opacity == 1)
            {
                Showanimation.Stop();
                
            }
            else
            {
                Opacity = Opacity + 0.1;

            }

        }
        private void Closeanimation_Tick(object sender, EventArgs e)
        {
            Opacity = Opacity - 0.1;

            if (Opacity == 0)
            {
                Closeanimation.Stop();
                Close();

            }

        }

        #endregion


        //Einzelne Einstellungen Tabs
        AllgemeinesTab at = new AllgemeinesTab();
        MarkerTab mt = new MarkerTab();
        ProgrammeTab pt = new ProgrammeTab();
        TimerTab tt = new TimerTab();
        Überwachung üt = new Überwachung();

        /// <summary>
        /// Kümmert sich um das anzeigen der einzelnen Menüpunkte
        /// </summary>
        /// <param name="number"></param>
        private void toggle(int number)
        {
            
            bTimer.selected = false;
            bAllgemeines.selected = false;
            bÜberwachung.selected = false;
            bProgramme.selected = false;
            bMarker.selected = false;

            //Einstellungen speichern
            einstellungen.Allgemeines = at.getSettings();
            einstellungen.Marker = mt.getSettings();
            einstellungen.Programme = pt.getSettings();
            einstellungen.Timer = tt.getSettings();
            einstellungen.Überwachung = üt.getSettings();


            panel1.Controls.Clear();

            switch (number)
            {

                case 0: bTimer.selected = true;

                    #region Tab anzeigen

                    tt.TopLevel = false;
                    tt.AutoScroll = true;

                    tt.setSettings(einstellungen.Timer);

                    panel1.Controls.Add(tt);
                    tt.Show();

                    #endregion

                    break;

                case 2: bAllgemeines.selected = true;

                    #region Tab anzeigen

                    at.TopLevel = false;
                    at.AutoScroll = true;

                    panel1.Controls.Add(at);

                    at.setSettings(einstellungen.Allgemeines);

                    at.Show();

                    #endregion

                    break;
                case 3: bÜberwachung.selected = true;

                    #region Tab anzeigen

                    üt.TopLevel = false;
                    üt.AutoScroll = true;

                    üt.setSettings(einstellungen.Überwachung);

                    panel1.Controls.Add(üt);
                    üt.Show();


                    #endregion


                    break;
                case 4: bProgramme.selected = true;

                    #region Tab anzeigen

                    pt.TopLevel = false;
                    pt.AutoScroll = true;

                    pt.setSettings(einstellungen.Programme);

                    panel1.Controls.Add(pt);
                    pt.Show();


                    #endregion


                    break;

                case 5: bMarker.selected = true;

                    #region Tab anzeigen

                    mt.TopLevel = false;
                    mt.AutoScroll = true;

                    mt.setSettings(einstellungen.Marker);

                    panel1.Controls.Add(mt);

                    mt.Show();


                    #endregion


                    break;


            }



        }
        
        //Tabs
        private void bTimer_Click(object sender, EventArgs e)
        {
            toggle(0);

        }
        private void bOrdner_Click(object sender, EventArgs e)
        {
            toggle(1);

        }
        private void bMarker_Click(object sender, EventArgs e)
        {
            toggle(2);
        }
        private void bÜberwachung_Click(object sender, EventArgs e)
        {
            toggle(3);
        }
        private void bProgramme_Click(object sender, EventArgs e)
        {
            toggle(4);
        }
        private void bMarker_Click_1(object sender, EventArgs e)
        {
            toggle(5);
        }

        //Animation für Tabswitching:
        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
           panel1.Visible = false;
            panelAnimator.Show(panel1);

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Closeanimation.Start();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            getAllSettings();

            einstellungen.save();
            Closeanimation.Start();

        }


    }
}

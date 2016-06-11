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
        public frmEinstellungen()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Closeanimation.Start();
        }

        private void frmEinstellungen_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Showanimation.Start();

            toggle(2);
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

            panel1.Controls.Clear();

            switch (number)
            {

                case 0: bTimer.selected = true;

                    TimerTab tt = new TimerTab();
                    tt.TopLevel = false;
                    tt.AutoScroll = true;

                    panel1.Controls.Add(tt);
                    tt.Show();

                    break;

                case 2: bAllgemeines.selected = true;

                    #region Tab anzeigen

                    AllgemeinesTab at = new AllgemeinesTab();
                    at.TopLevel = false;
                    at.AutoScroll = true;

                    panel1.Controls.Add(at);
                    at.Show();


                    #endregion

                    break;
                case 3: bÜberwachung.selected = true;

                    #region Tab anzeigen

                    Überwachung üt = new Überwachung();
                    üt.TopLevel = false;
                    üt.AutoScroll = true;

                    panel1.Controls.Add(üt);
                    üt.Show();


                    #endregion


                    break;
                case 4: bProgramme.selected = true;

                    #region Tab anzeigen

                    ProgrammeTab pt = new ProgrammeTab();
                    pt.TopLevel = false;
                    pt.AutoScroll = true;

                    panel1.Controls.Add(pt);
                    pt.Show();


                    #endregion


                    break;

                case 5: bMarker.selected = true;

                    #region Tab anzeigen

                    MarkerTab mt = new MarkerTab();
                    mt.TopLevel = false;
                    mt.AutoScroll = true;

                    panel1.Controls.Add(mt);
                    mt.Show();


                    #endregion


                    break;


            }



        }
        

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bMarker_Click_1(object sender, EventArgs e)
        {
            toggle(5);
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
           panel1.Visible = false;
            animator1.Show(panel1);

        }
    }
}

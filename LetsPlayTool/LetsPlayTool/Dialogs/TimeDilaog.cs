using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Dialogs
{
    public partial class TimeDilaog : Form
    {
        public TimeDilaog()
        {
            InitializeComponent();
        }

        #region Move Form

        private Point mouseposition;

        private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseposition = new Point(-e.X, -e.Y);

        }
        private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseposition.X, mouseposition.Y);
                Location = mousePos;
            }

        }



        #endregion

        /// <summary>
        /// Beenden des Dialogs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
                        
        }
        private void bAbbrechen_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.None;
            Close();


        }

        private void bFertig_Click(object sender, EventArgs e)
        {

            Stunden = nudTimeHours.Value;
            Minuten = nudTimeMinutes.Value;
            Sekunden = nudTimeMSeconds.Value;
            Millisekunden = nudTimeMSeconds.Value;


            if (checkText.Checked)
            {

                TimerText = richTextBox1.Text;

                if (cbFormat.selectedIndex == 0)
                {
                    isBig = false;
                }
                else
                {
                    isBig = true;

                }

            }


            DialogResult = DialogResult.OK;

        }

        public decimal Stunden { get; private set; }
        public decimal Minuten { get; private set; }
        public decimal Sekunden { get; private set; }
        public decimal Millisekunden { get; private set; }

        public string TimerText { get; private set; }
        public bool isBig { get; set; }

        public Color Farbe = Color.Green;

        private void bFarbe_Click(object sender, EventArgs e)
        {
            if(cdFarbe.ShowDialog() == DialogResult.OK)
            {

                Farbe = cdFarbe.Color;
                bFarbe.Normalcolor = Farbe;
                bFarbe.Activecolor = Farbe;
                bFarbe.BackColor = Farbe;


            }
        }

        private void TimeDilaog_KeyDown(object sender, KeyEventArgs e)
        {
            //Enter
            if(e.KeyCode == Keys.Enter)
            {
                if (cdFarbe.ShowDialog() == DialogResult.OK)
                {

                    Farbe = cdFarbe.Color;
                    bFarbe.Normalcolor = Farbe;
                    bFarbe.Activecolor = Farbe;
                    bFarbe.BackColor = Farbe;

                }

            }

            //Abbrechen
            if(e.KeyCode == Keys.Escape)
            {

                DialogResult = DialogResult.None;
                Close();


            }

        }

        private void checkShift_OnChange(object sender, EventArgs e)
        {

            panelText.Enabled = checkText.Checked;

        }
    }
}

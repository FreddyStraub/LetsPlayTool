using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Update
{
    public partial class frmUpdate : Form
    {

        string _pic;
        string _changelog;
        string _version;
        string _download;

        public frmUpdate(string pic, string changelog, string version, string download)
        {
            InitializeComponent();

            _changelog = changelog;
            _version = version;
            _download = download;
            _pic = pic;

        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {

            richTextBox1.Text = _changelog;

            try
            {

                HttpWebRequest logRequest = (HttpWebRequest)HttpWebRequest.Create(_changelog);
                HttpWebResponse logResponse = (HttpWebResponse)logRequest.GetResponse();

                System.IO.StreamReader updateReader = new System.IO.StreamReader(logResponse.GetResponseStream());

                richTextBox1.Text = updateReader.ReadToEnd();

                lbVersion.Text = _version;

            }catch(Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten: " + ex.Message.ToString());
                Application.Exit();

            }

            //Bild

            try
            {
                var request = WebRequest.Create(_pic);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pbUpdatePic.Image = Bitmap.FromStream(stream);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten: " + ex.Message.ToString());
                Application.Exit();

            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                WebClient wb = new WebClient();

                richTextBox1.Text = "Downloading...";
                richTextBox1.Font = new Font(richTextBox1.Font.Name, 40f, FontStyle.Regular);

                //wb.DownloadFile(new Uri(_download), "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool\\LetsPlayToolSetup.exe");
                //System.Diagnostics.Process.Start("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LetsPlayTool\\LetsPlayToolSetup.exe");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Folgender Fehler ist aufgetreten: " + ex.Message.ToString());
                Application.Exit();


            }

          //  Application.Exit();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
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

    }
}

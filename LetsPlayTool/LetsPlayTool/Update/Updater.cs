using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayTool.Update
{
    public class Updater
    {

        public Updater()
        {
            request = (HttpWebRequest)HttpWebRequest.Create(txtUrl);
            response = (HttpWebResponse)request.GetResponse();


            System.IO.StreamReader updateReader = new System.IO.StreamReader(response.GetResponseStream());

            newVersion = updateReader.ReadLine();
            downloadurl = updateReader.ReadLine();
            updatepicurl = updateReader.ReadLine();
            changelogurl = updateReader.ReadLine();

            updateReader.Close();

        }

        string txtUrl = "https://www.dropbox.com/s/smfvet997p8je3s/update.txt?dl=1";

        public string downloadurl;
        public string updatepicurl;
        public string changelogurl;
        public string newVersion;

        HttpWebRequest request;
        HttpWebResponse response;

        /// <summary>
        /// Gibt an ob ein neues Update verfügbar ist.
        /// </summary>
        /// <returns></returns>
        public bool UpdateAvailable()
        {
            
            if (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() == newVersion)
            {
                return false;
            }else
            {
                return true;
            }

         
        }

        /// <summary>
        /// Updatet das Tool
        /// </summary>
        public void update()
        {

            frmUpdate frmUpdate = new frmUpdate(updatepicurl, changelogurl, newVersion, downloadurl);
            frmUpdate.ShowDialog();

        }

    }
}

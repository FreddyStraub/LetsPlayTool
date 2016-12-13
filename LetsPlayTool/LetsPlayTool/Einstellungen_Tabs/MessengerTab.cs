using LetsPlayTool.Einstellungen_Tabs.Messenger;
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
    public partial class MessengerTab : Form
    {
        public MessengerTab()
        {
            InitializeComponent();
        }

        private void MessengerTab_Load(object sender, EventArgs e)
        {
            toggle(0);
        }

        SkypeTab st = new SkypeTab();

        MessengerTabEinstellungen einstellungen;

        private void toggle(int messengerIndex)
        {

            einstellungen.Skype = st.getSettings();

            switch (messengerIndex)
            {

                case 0:

                    #region Tab anzeigen

                    st.TopLevel = false;
                    st.AutoScroll = true;
                    
                    st.setSettings(einstellungen.Skype);

                    bcSkype.Controls.Add(st);
                    st.Show();

                    #endregion


                    break;

            }

        }


        public void setSettings(MessengerTabEinstellungen Settings)
        {
            einstellungen = Settings;

            st.setSettings(einstellungen.Skype);
            
        }
        public MessengerTabEinstellungen getSettings()
        {

            MessengerTabEinstellungen newSettings = new MessengerTabEinstellungen();

            newSettings.Skype = st.getSettings();

            return newSettings;

        }


        private void bSkype_Click(object sender, EventArgs e)
        {

            toggle(0);

        }
    }
}

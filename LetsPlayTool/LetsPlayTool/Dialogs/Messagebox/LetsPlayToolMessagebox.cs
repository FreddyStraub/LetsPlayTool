using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsPlayTool.Dialogs.Messagebox
{
    public class LetsPlayToolMessagebox
    {
        /// <summary>
        /// Type of Messagebox
        /// </summary>
        public enum LetsPlayToolMessageBoxType
        {
            OK, YesNo
        };

        /// <summary>
        /// Type of Messagebox
        /// </summary>
        public enum LetsPlayToolMessageBoxSound
        {
            Asterisk, Exclamation, Hand, Beep, None
        };

        /// <summary>
        /// Zeigt eine Messagebox im Style des LetsPlayTools an.
        /// </summary>
        /// <param name="Text">Text der Angezeig werden soll.</param>
        /// <param name="Title">Title des Fensters</param>
        /// <param name="MessageBoxType">Aussehen/Anzahl Buttons</param>
        /// <param name="Sound">Sound der beim öffnen abgespielt werden soll.</param>
        /// <returns></returns>
        public static DialogResult Show(string Text, string Title, LetsPlayToolMessageBoxType MessageBoxType, LetsPlayToolMessageBoxSound Sound)
        {
            DialogResult dr = new DialogResult();

            switch (MessageBoxType)
            {

                case LetsPlayToolMessageBoxType.OK:

                    frmMessageboxOK frmMessageboxOK = new frmMessageboxOK(Text, Title);

                    playSound(Sound);

                    dr = frmMessageboxOK.ShowDialog();

                    break;

                case LetsPlayToolMessageBoxType.YesNo:

                    frmMessageboxYesNo frmMessageboxYesNo = new frmMessageboxYesNo(Text, Title);

                    playSound(Sound);

                    dr = frmMessageboxYesNo.ShowDialog();

                    break;
                    
            }



            return dr;

        }


        /// <summary>
        /// Spielt den übergebenen Systemsound ab.
        /// </summary>
        /// <param name="Sound">Sound der abgespielt werden soll</param>
        private static void playSound(LetsPlayToolMessageBoxSound Sound)
        {
            switch (Sound)
            {
                case LetsPlayToolMessageBoxSound.Asterisk:

                    SystemSounds.Asterisk.Play();

                    break;

                case LetsPlayToolMessageBoxSound.Beep:

                    SystemSounds.Beep.Play();

                    break;

                case LetsPlayToolMessageBoxSound.Exclamation:

                    SystemSounds.Exclamation.Play();

                    break;

                case LetsPlayToolMessageBoxSound.Hand:

                    SystemSounds.Hand.Play();

                    break;


            }

        }

    }
}

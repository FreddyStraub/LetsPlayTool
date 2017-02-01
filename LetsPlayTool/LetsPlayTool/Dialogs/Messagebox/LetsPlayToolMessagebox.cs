using System;
using System.Collections.Generic;
using System.Linq;
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
        public enum Type
        {
            OK, YesNo
        };

        /// <summary>
        /// Zeigt eine Messagebox im Style des LetsPlayTools an.
        /// </summary>
        /// <param name="Text">Text der Angezeig werden soll.</param>
        /// <param name="Title">Title des Fensters</param>
        /// <param name="MessageBoxType">Aussehen/Anzahl Buttons</param>
        /// <returns></returns>
        public static DialogResult Show(string Text, string Title, Type MessageBoxType)
        {
            DialogResult dr = new DialogResult();

            switch (MessageBoxType)
            {

                case Type.OK:

                    frmMessageboxOK frmMessageboxOK = new frmMessageboxOK(Text, Title);
                    dr = frmMessageboxOK.ShowDialog();

                    break;

            }

            return dr;

        }

    }
}

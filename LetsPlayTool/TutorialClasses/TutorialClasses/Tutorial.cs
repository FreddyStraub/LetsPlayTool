using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TutorialClasses
{
    [Serializable]
    public class Tutorial
    {

        public List<TutorialCard> Cards = new List<TutorialCard>();

        public string title { get; set; }

        /// <summary>
        /// Lädt ein Tutorial 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Tutorial load(string path)
        {

            Tutorial newt = new Tutorial();


            FileStream FS = new FileStream(path, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            newt = (Tutorial)BF.Deserialize(FS);

            FS.Dispose();


            return newt;

        }

        /// <summary>
        /// Speicher die Einstellungen
        /// </summary>
        public void save(string path)
        {

            string pfad = path + "\\" + title + ".tut";

            FileStream FS = new FileStream(pfad, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();


        }


    }
}

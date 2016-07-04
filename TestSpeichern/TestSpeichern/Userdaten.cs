using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestSpeichern
{
    [Serializable]
    public class Userdaten
    {

        public string name { get; set; }
        public int alter { get; set; }


        public void save(string path)
        {

            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();

            BF.Serialize(FS, this);

            FS.Dispose();

        }

        public Userdaten load(string path)
        {

            Userdaten US = new Userdaten();

            System.IO.FileStream FS = new System.IO.FileStream(path, System.IO.FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();

            US = (Userdaten)BF.Deserialize(FS);

            return US;

        }

    }
}

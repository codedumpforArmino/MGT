using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MGT
{
    static internal class GameLogger
    {
        public static void SaveGameLibrary(ArrayList LoadedLibrary)
        {
            ArrayList GameLibrary = LoadedLibrary;
            File savefile = new File("library.dat");
            //b.Serialize(Stream, object);
        }

        public static ArrayList LoadGameLibrary() {
            
        }

    }
}

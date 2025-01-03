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
        //implement serialization and deserialization
        public static void SaveGameLibrary(ArrayList LoadedLibrary)
        {
            ArrayList GameLibrary = LoadedLibrary;
            //b.Serialize(Stream, object);
        }

        public static ArrayList LoadGameLibrary() {
            return new ArrayList();
        }

        public static void SaveLogList(ArrayList LoadedLogList)
        {
            ArrayList LogList = new ArrayList();
        }

        public static ArrayList LoadLogList()
        {
            return new ArrayList(); 
        }
    }
}

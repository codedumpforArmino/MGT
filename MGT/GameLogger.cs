using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Diagnostics;

namespace MGT
{
    static internal class GameLogger
    {
        //implement serialization and deserialization
        public static void SaveGameLibrary(List<Game> LoadedLibrary)
        {
            string gameLibFileName = "gamelib.json";
            List<Game> GameLibrary = LoadedLibrary;

            var options = new JsonSerializerOptions { WriteIndented = true };
            string JSON_gameLibrary = JsonSerializer.Serialize(GameLibrary, options);
            File.WriteAllText(gameLibFileName, JSON_gameLibrary);

            Debug.WriteLine(JSON_gameLibrary);
        }

        public static async Task<List<Game>> LoadGameLibrary() {
            string gameLibFileName = "gamelib.json";
            using FileStream openStream = File.OpenRead(gameLibFileName);
            List<Game>? GameLibrary = await JsonSerializer.DeserializeAsync<List<Game>>(openStream); 

            //check if Json file is not found, if Json list is empty
            foreach(var game in GameLibrary)
            {
                Debug.WriteLine(game.Name);
            }
            

            return GameLibrary;
        }

        public static void SaveLogList(ArrayList LoadedLogList)
        {
            ArrayList LogList = LoadedLogList;
        }

        public static ArrayList LoadLogList()
        {
            return new ArrayList(); 
        }
    }
}

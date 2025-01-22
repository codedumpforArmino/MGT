using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGT
{
    internal class Game
    {
        public string Name { get; set; }
        public string GameFilePath { get; set; }
        public string platform { get; set; }
        public float TotalHours { get; set; }

        public Game(string intputName)
        {
            Name = intputName;
            GameFilePath = "test";
            platform = "test";
            TotalHours = 0;
        }

        public void IncrementHours(int minutes)
        {
            TotalHours += (minutes / 60);
        }
        //Add filepath
        //add platform
    }
}

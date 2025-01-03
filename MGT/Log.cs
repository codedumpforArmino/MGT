using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGT
{
    internal class Log
    {
        string gamePlayed;
        DateTime datePlayed;
        int Duration_inMinutes;

        public Log(string inputGame, DateTime inputDate)
        {
            gamePlayed = inputGame;
            datePlayed = inputDate;
            Duration_inMinutes = 10;
        }

        public void setDuration(int duration) {
            Duration_inMinutes = duration;
        }

        public override string ToString()
        {
            return "Game: " + gamePlayed + "\nDate Played: " + datePlayed + "\nDuration: " + Duration_inMinutes;
        }
    }
}

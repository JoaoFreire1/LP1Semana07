using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore = 0;
        private int playedGames = 0;
        private int wonGames = 0;

        public float HighScore {get => highScore; set => highScore = (highScore < value) ? value : highScore;}

        public string Name {get; set; }
        public float WinRate
        {
            get => (playedGames == 0) ? 0 : (float)wonGames / playedGames;
        }

        public void PlayGame (bool win)
        {
            playedGames++;
            if (win == true)
            {
                wonGames++;
            }
        }

        public Player(string Name)
        {
            this.Name = Name;
        }
    }
}
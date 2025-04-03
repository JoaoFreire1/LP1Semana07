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
        private int playedGames;
        private int wonGames;

        private float HighScore {set => highScore = (highScore < value) ? value : highScore;}

        private string Name {get; set; }
        private readonly WinRate { get => winrate = (playedGames < 0) ? 0 : (playedGames/wonGames);}
    }
}
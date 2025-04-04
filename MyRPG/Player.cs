using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Player
    {
        private int xp = 0;
        private float health;
        public string Name {get; set; }
        public float XP {get => xp; set => xp = (xp + value);}
        public float Level
        {
            get => (level == 0) ? 0 : (float)(1 + xp) / 1000;
        }
    }
}
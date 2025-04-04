using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Player
    {
        private int level;
        private int xp;
        private int health;
        private int maxHealth;

        public string Name { get; }
        public int Level
        {
            get { return level; }
            private set { level = value; }
        }
        public int XP
        {
            get { return xp; }
            set
            {
                xp = value;
                if (xp >= 1250 && (xp/1250)>(level-1)) LevelUp();
            }
        }
        public int Health
        {
            get { return health; }
            set { health = Math.Min(Math.Max(value, 0), MaxHealth); }
        }
    }
}
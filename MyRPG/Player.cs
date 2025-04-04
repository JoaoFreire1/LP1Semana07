using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Player
    {
        private int level;
        private int xp = 0;
        private float health;
        private float maxHealth;

        public string Name { get; }
        public int Level
        {
            get { return level; }
            private set { level = value;  }
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
        public float Health
        {
            get { return health; }
            set { health = Math.Min(Math.Max(value, 0), MaxHealth); }
        }

        public float MaxHealth
        {
            get { return maxHealth; }
            private set { maxHealth = value; }
        }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            XP = 0;
            MaxHealth = 100 + (level - 1) * 20;
            Health = MaxHealth;
        }

        private void LevelUp()
        {
            if((XP / 1250) > 0)
            {
                var levels = XP / 1250;
                Level += levels;
                MaxHealth = 100 + ((Level-1) * 20);
            }
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
            XP += 2;
        }
    }
}
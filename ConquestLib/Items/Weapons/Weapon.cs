using System;
using System.Collections.Generic;
using System.Text;

namespace ConquestLib.Items.Weapons
{
    public class Weapon : Item
    {
        private int range;
        private int minDamage;
        private int maxDamage;
        private int usedHands;

        public int Range
        {
            get
            {
                return range;
            }
            set
            {
                range = value;
            }
        }

        public int MinDamage
        {
            get
            {
                return minDamage;
            }
            set
            {
                minDamage = value;

                if (minDamage < 0)
                {
                    minDamage = 0;
                }
            }
        }
        public int MaxDamage
        {
            get
            {
                return maxDamage;
            }
            set
            {
                maxDamage = value;

                if (maxDamage < minDamage)
                {
                    maxDamage = minDamage;
                }
            }
        }
        public int UsedHands
        {
            get
            {
                return usedHands;
            }
            set
            {
                usedHands = value;
            }
        }

        public Weapon(int healthIncrease, int staminaIncrease, int armourIncrease, int rangeIncrease, int range, int minDamage, int maxDamage, int usedHands)
            : base (healthIncrease, staminaIncrease, armourIncrease, rangeIncrease)
        {
            this.range = range;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.usedHands = usedHands;
        }
    }

}

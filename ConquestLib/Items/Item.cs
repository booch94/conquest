using System;
using System.Collections.Generic;
using System.Text;

namespace ConquestLib.Items
{
    public class Item
    {
        private int healthIncrease;
        private int staminaIncrease;
        private int armourIncrease;
        private int rangeIncrease;

        public int HealthIncrease
        {
            get
            {
                return healthIncrease;
            }
            set
            {
                healthIncrease = value;
            }
        }
        public int StaminaIncrease
        {
            get
            {
                return staminaIncrease;
            }
            set
            {
                staminaIncrease = value;
            }
        }
        public int ArmourIncrease
        {
            get
            {
                return armourIncrease;
            }
            set
            {
                armourIncrease = value;
            }
        }
        public int RangeIncrease
        {
            get
            {
                return rangeIncrease;
            }
            set
            {
                rangeIncrease = value;
            }
        }
        public Item(int healthIncrease, int staminaIncrease, int armourIncrease, int rangeIncrease)
        {
            this.healthIncrease = healthIncrease;
            this.staminaIncrease = staminaIncrease;
            this.armourIncrease = armourIncrease;
            this.rangeIncrease = rangeIncrease;
        }
    }
}

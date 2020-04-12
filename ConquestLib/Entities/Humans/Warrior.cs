using System;
using System.Collections.Generic;
using System.Text;

namespace ConquestLib.Entities.Humans
{
    public class Warrior : Human
    {
        private int minDamage;
        private int maxDamage;
        private int armor;

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

                if (maxDamage < 0)
                {
                    maxDamage = 0;
                }
                if (maxDamage < minDamage)
                {
                    maxDamage = minDamage;
                }
            }
        }
        public int Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
                if (armor < 0)
                {
                    armor = 0;
                }
            }
        }

        public Warrior(int initialHealth, string firstName, string lastName, int initialStamina)
            : base(initialHealth, firstName, lastName, initialStamina)
        {
            this.Health = initialHealth;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Stamina = initialStamina;
            this.MinDamage = 1;
            this.MaxDamage = 2;
            this.Armor = 0;
        }




    }
}

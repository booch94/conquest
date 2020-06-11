using ConquestLib.Items;
using System;
using System.Collections.Generic;
using System.Text;
using ConquestLib.Items.Weapons;

namespace ConquestLib.Entities
{
    public class Human : Entity
    {
        private string firstName;
        private string lastName;
        private int stamina;
        private Entity target;
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
        public string FirstName 
        {
            get 
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int Stamina
        {
            get
            {
                return stamina;
            }

            set
            {
                stamina = value;
            }
        }
        public Entity Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;

            }
        }

        public Human(int initialHealth, string firstName, string lastName, int initialStamina) 
            : base (initialHealth)
        {
            this.Health = initialHealth;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Stamina = initialStamina;
            this.Target = null;
            this.MinDamage = 1;
            this.MaxDamage = 2;
            this.Armor = 0;
        }

        public void SetTarget(Entity target)
        {
            this.Target = target;
        }

        public void ClearTarget()
        {
            this.Target = null;
        }

        public void Attack(Weapon weapon)
        {
            if(weapon == null)
            {
                this.Target.Health -= this.minDamage; 
            }
            else
            {
                this.Target.Health -= this.minDamage + weapon.MinDamage;
            }
        }
    }
}

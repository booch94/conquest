using System;
using System.Collections.Generic;
using System.Text;

namespace ConquestLib.Entities
{
    public class Human : Entity
    {
        private string firstName;
        private string lastName;
        private int stamina;
        private Entity target;

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
        }

        public void SetTarget(Entity target)
        {
            this.Target = target;
        }

        public void ClearTarget()
        {
            this.Target = null;
        }
    }
}

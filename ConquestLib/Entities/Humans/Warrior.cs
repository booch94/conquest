using System;
using System.Collections.Generic;
using System.Text;

namespace ConquestLib.Entities.Humans
{
    public class Warrior : Human
    {
        

        public Warrior(int initialHealth, string firstName, string lastName, int initialStamina)
            : base(initialHealth, firstName, lastName, initialStamina)
        {
            this.Health = initialHealth;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Stamina = initialStamina;
           
        }




    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConquestLib.Entities
{
    public class Entity
    {
        private int health;
        private bool alive;


        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health += value;
                if (health <= 0)
                {
                    alive = false;
                    Console.WriteLine("You are dead");
                }
            }

        }


        public Entity(int initialHealth)
        {
            health = initialHealth;
            alive = true;
        }
    }
}

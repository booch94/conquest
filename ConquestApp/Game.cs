using System;
using ConquestLib.Entities;
using ConquestLib.Entities.Humans;
using ConquestLib.Items;
using ConquestLib.Items.Weapons;

namespace ConquestApp
{
    class Game
    {
        static void Main(string[] args)
        {
            Human pesho = new Human(100, "Pesho", "Peshov", 98);
            Warrior asparuh = new Warrior(100, "Han", "Asparagus", 1000);
            Weapon axe = new Weapon(10, 10, 100, 5, 50, 50, 51, 1);
            asparuh.SetTarget(pesho);
            asparuh.Attack(axe);
            Console.WriteLine(asparuh.Target.Health);
        }
    }
}

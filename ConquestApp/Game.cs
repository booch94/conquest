using System;
using ConquestLib.Entities;
using ConquestLib.Entities.Humans;

namespace ConquestApp
{
    class Game
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(1, "Pesho", "Petrov", 100);
            Warrior asparuh = new Warrior(100, "Han", "Asparuh", 100);

            asparuh.SetTarget(human1);
            Console.WriteLine(asparuh.Target.Health);
        }
    }
}

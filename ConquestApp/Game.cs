using System;
using ConquestLib.Entities;

namespace ConquestApp
{
    class Game
    {
        static void Main(string[] args)
        {
            Human pesho = new Human(100, "Pesho", "Petrov", 100);

            Console.WriteLine(pesho.Health);
            Console.WriteLine(pesho.FirstName);
            Console.WriteLine(pesho.LastName);
            Console.WriteLine(pesho.Stamina);
            Console.WriteLine(pesho.Alive);

            pesho.Health -= 100;
            Console.WriteLine(pesho.Alive);
        }
    }
}

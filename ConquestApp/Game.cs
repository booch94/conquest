using System;
using ConquestLib.Entities;

namespace ConquestApp
{
    class Game
    {
        static void Main(string[] args)
        {
            Entity pesho = new Entity(100);
            Console.WriteLine(pesho.Health);
        }
    }
}

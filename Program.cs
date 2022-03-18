using System;
using Cars;
using GameCycle;

namespace CARS
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game(new F1("Dima"), new F1("Alex"), new F2("Max"), new F3("Ktoto"));

            game.Start();

            Console.ReadLine(); 
        }
    }
}


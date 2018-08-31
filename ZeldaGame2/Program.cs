using System;
using ZeldaGame2.controller;

namespace ZeldaGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ZELDA IN C# ***");

            var game = new GameController();
            game.Start();
        }
    }
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome player, choose a name
            Console.WriteLine("Hello, what's your name?");
            string UserInput = Console.ReadLine();
            
            var player1 = new Player();
            player1.SetName(UserInput);

            Console.WriteLine("Welcome to the game " + player1.GetName());
            Console.ReadLine();
        }
    }
}

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

            Console.WriteLine("You are currently at position " + player1.GetCoordinateX() + "," + player1.GetCoordinateY());
            Console.WriteLine("Where do you want to go?");
            string UserInput2 = Console.ReadLine();

            player1.Move(UserInput2);
            Console.ReadLine();
        }
    }
}

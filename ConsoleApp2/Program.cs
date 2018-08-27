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
            player1.Name = (UserInput); // C# version of set.

            Console.WriteLine("Welcome to the game " + player1.Name);

            Console.WriteLine("You are currently at position " + player1.CoordinateX + "," + player1.CoordinateY);
            Console.WriteLine("Where do you want to go?");
            string UserInput2 = Console.ReadLine();

            player1.Move(UserInput2);
            Console.WriteLine("You are currently at position " + player1.CoordinateX + "," + player1.CoordinateY);

            Console.ReadLine();
        }
    }
}

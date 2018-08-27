using System;

namespace ZeldaGame
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

            Console.WriteLine("You are standing in an open clearing in a forest");

            while (player1.playing)
            {

                // Console.WriteLine("You are currently at position " + player1.CoordinateX + "," + player1.CoordinateY);
                Console.WriteLine("Where do you want to go?");
                string UserInput2 = Console.ReadLine();
                player1.Move(UserInput2);
                if(player1.CoordinateX == 1 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You are standing in an open clearing in a forest");
                }
                if(player1.CoordinateX == 0 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You hear screaming in the west: " + player1.Name + "!!!");
                }
                if(player1.CoordinateX == -1 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You see a girl being cornered by a group of trolls. What do you do?");
                    break;
                }
                else if(player1.CoordinateX > 2 || player1.CoordinateX < 0 || player1.CoordinateY > 2 || player1.CoordinateY < 0)
                {
                    Console.WriteLine("You see nothing but trees around you");
                }

                
                
            }

            Console.WriteLine("Too late! The trolls eat you.");
            Console.WriteLine("Game over");
            Console.ReadLine();
        }
    }
}

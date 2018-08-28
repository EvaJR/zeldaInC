using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame
{
    class Level1
    {

        public void PlayLevel1(Player player1)
        {

            Console.WriteLine("You are standing in an open clearing in a forest");

            bool BranchInClearing = true;

            while (player1.playing)
            {

                // Console.WriteLine("You are currently at position " + player1.CoordinateX + "," + player1.CoordinateY);
                Console.WriteLine("Where do you want to go?");
                string UserInput2 = Console.ReadLine();
                if (UserInput2 == "q")
                {
                    player1.playing = false;
                    Console.WriteLine("Bye!");
                    break;
                }

                player1.Move(UserInput2);
                if (player1.CoordinateX == 1 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You are standing in an open clearing in a forest");
                }
                if (player1.CoordinateX == 0 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You hear screaming in the west: " + player1.Name + "!!!");
                }
                if (player1.CoordinateX == -1 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You see a girl being cornered by a group of trolls. What do you do?");
                    Console.WriteLine("Too late! The trolls eat you.");
                    Console.WriteLine("GAME OVER");
                    Console.ReadLine();

                }
                if (player1.CoordinateX == 1 && player1.CoordinateY == 0 && BranchInClearing)
                {
                    Console.WriteLine("You see a branch lying in the grass");
                    Item branch = new Weapon("branch");
                    player1.Inventory.Add(branch);
                    BranchInClearing = false;
                    foreach (Item item in player1.Inventory)
                    {
                        Console.WriteLine("Your inventory now contains " + item.Name);
                    }

                }
                else if (player1.CoordinateX > 2 || player1.CoordinateX < 0 || player1.CoordinateY > 2 || player1.CoordinateY < 0)
                {
                    Console.WriteLine("You see nothing but trees around you");
                }

            }

            Console.ReadLine();

        }
    }
    
}

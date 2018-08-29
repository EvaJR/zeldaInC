using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame.controller;
using ZeldaGame.model;

namespace ZeldaGame
{
    class Level1
    {

        public void PlayLevel1(Player player1)
        {

            Console.WriteLine("You are standing in an open clearing in a forest");

            bool BranchInClearing = true;
            bool RupeeInClearing = true;
            bool Rupee2InClearing = true;

            while (player1.playing)
            {

                // Console.WriteLine("You are currently at position " + player1.CoordinateX + "," + player1.CoordinateY);
                Console.WriteLine("Where do you want to go?");
                string UserInput2 = Console.ReadLine();

                player1.Move(UserInput2);

                if (player1.CoordinateX == 0 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You hear screaming in the west: " + player1.Name + "!!!");
                }
                if (player1.CoordinateX == -1 && player1.CoordinateY == 1)
                {
                    Console.WriteLine("You see a girl being cornered by a group of trolls. What do you do?");

                    if(player1.Inventory.Count == 0)
                    {
                        Console.WriteLine("You desperately look around for something to use as a weapon...");
                        Console.WriteLine("Too late! The trolls eat you.");
                        Console.WriteLine("GAME OVER");

                    }
                    else
                    {
                        Console.WriteLine("Your equipped weapon is " + player1.EquippedWeapon.Name);
                        Console.WriteLine("You hit the trolls over the head with your " + player1.EquippedWeapon.Name);
                        Console.WriteLine("You save the girl");

                        var level2 = new Level2();
                        level2.PlayLevel(player1);
                    }
                    

                    Console.ReadLine();

                }
                if (player1.CoordinateX == 1 && player1.CoordinateY == 0 && BranchInClearing)
                {
                    Console.WriteLine("You see a branch lying in the grass");
                    Item branch = new Weapon("branch");
                    player1.Inventory.Add(branch);
                    player1.EquippedWeapon = branch as Weapon;
                    BranchInClearing = false;
                    player1.ShowInventory(player1.Inventory);

                }

                if (player1.CoordinateX == 2 && player1.CoordinateY == 0 && RupeeInClearing)
                {
                    Console.WriteLine("You pick up a shiny green rupee");
                    Rupee rupee = new Rupee(1);
                    player1.RupeeTotal += rupee.Value;
                    RupeeInClearing = false;

                }

                if (player1.CoordinateX == 2 && player1.CoordinateY == 1 && Rupee2InClearing)
                {
                    Console.WriteLine("You pick up a shiny blue rupee");
                    Rupee rupee = new Rupee(5);
                    player1.RupeeTotal += rupee.Value;
                    Rupee2InClearing = false;

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

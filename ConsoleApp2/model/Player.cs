﻿using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame.model;

namespace ZeldaGame
{
    class Player
    {
        // private string Name { get; set; }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
               // if (Name.Length < 20) // this logic is now in Welcome > NullPointerException? hm
                {
                    name = value; // add logic here 
                }
            }
        }
        public int CoordinateX { get; set; } = 1;
        public int CoordinateY { get; set; } = 1;
        public bool playing { get; set; } = true;

        // create an inventory of Items
        public List<Item> Inventory { get; set; } = new List<Item>();
        public int RupeeTotal { get; set; } = 0;

        public void Move(string UserInput)
        {
            switch (UserInput)
            {
                case "north":
                    CoordinateY--;
                    break;
                case "east":
                    CoordinateX++;
                    break;
                case "west":
                    CoordinateX--;
                    break;
                case "south":
                    CoordinateY++;
                    break;
                case "q":
                    Console.WriteLine("Bye!");
                    playing = false;
                    break;
                case "i":
                    ShowInventory(Inventory);
                    break;
                default:
                    Console.WriteLine("Did you mean north, south, east or west?");
                    break;
            }
        }

        public void ShowInventory(List<Item> inventory)
        {
            
            Console.WriteLine("*** INVENTORY ***");
            Console.WriteLine("Rupees: " + RupeeTotal);
            if (inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty");
            }

            foreach (Item item in inventory)
            {
                if (item is Weapon)
                {
                    Console.WriteLine("Weapons:");
                    Console.WriteLine(" * " + item.Name);
                }
            }


        }

    }
}

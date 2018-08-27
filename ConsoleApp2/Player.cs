using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
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
                if (value == "")
                {
                    Console.WriteLine("Please enter a name");
                }
                name = value; // add logic here
            }
        }
        public int CoordinateX { get; set; } = 1;
        public int CoordinateY { get; set; } = 1;

        public void Move(string UserInput)
        {
            switch (UserInput)
            {
                case "north":
                    Console.WriteLine("North");
                    CoordinateY++;

                    break;
                case "east":
                    Console.WriteLine("East");
                    break;
                case "west":
                    Console.WriteLine("West");
                    break;
                case "south":
                    Console.WriteLine("South");
                    break;
                default:
                    Console.WriteLine("Did you mean north, south, east or west?");
                    break;
            }
        }

    }
}

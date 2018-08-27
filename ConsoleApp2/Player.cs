using System;
using System.Collections.Generic;
using System.Text;

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
                
                
                name = value; // add logic here 
            }
        }
        public int CoordinateX { get; set; } = 1;
        public int CoordinateY { get; set; } = 1;
        public bool playing { get; set; } = true;

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
                default:
                    Console.WriteLine("Did you mean north, south, east or west?");
                    break;
            }
        }

    }
}

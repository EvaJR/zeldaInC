using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Player
    {
        // private string Name { get; set; }
        private string Name;
        private int CoordinateX = 1;
        private int CoordinateY = 1;

        public void Move(string UserInput)
        {
            switch (UserInput)
            {
                case "north":
                    Console.WriteLine("North");
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

        public string GetName ()
        {
            return Name;
        }

        public void SetName (string Name)
        {
            this.Name = Name;
        }

        public int GetCoordinateX()
        {
            return CoordinateX;
        }

        public void SetCoordinateX(int CoordinateX)
        {
            this.CoordinateX = CoordinateX;
        }

        public int GetCoordinateY()
        {
            return CoordinateY;
        }

        public void SetCoordinateY(int CoordinateY)
        {
            this.CoordinateY = CoordinateY;
        }

    }
}

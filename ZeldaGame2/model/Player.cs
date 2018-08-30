using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame2.model
{
    class Player
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }

        public Player(int x, int y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

    }
}

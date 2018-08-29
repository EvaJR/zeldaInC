using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame.model;

namespace ZeldaGame
{
    class Map
    {
        
        // add tiles to the array

        public Tile[,] BuildMap()
        {
            Tile[,] Array2D = new Tile[3, 3];
            var middle = new Tile("You see a sword in a pedestal");
            middle.HasSword = true;
            var back = new Tile("There's a girl standing in the cave ");
            var cave = new Tile("You are inside a cave");
            var entrance = new Tile("You see the cave entrance to the south");
            Array2D[1, 1] = middle; 
            Array2D[1, 0] = back;
            Array2D[1, 2] = entrance;
            for (int i = 0; i < 3; i++)
            {
                Array2D[0, i] = cave;
                Array2D[2, i] = cave;
            }

            return Array2D;


        }

        // or use a 2D List?

        List<List<Tile>> List2D = new List<List<Tile>>();

        List<Tile> List1D = new List<Tile>();



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame2.model
{
    class Map
    {
        public Tile[,] MapTiles { get; set; } = new Tile[3, 3];

        public void BuildMap()
        {
            MapTiles[0, 0] = new Tile("clearing");
            MapTiles[0, 1] = new Tile("clearing");
            MapTiles[0, 2] = new Tile("clearing");

            MapTiles[1, 0] = new Tile("clearing");
            MapTiles[1, 1] = new Tile("clearing");
            MapTiles[1, 2] = new Tile("clearing");

            MapTiles[2, 0] = new Tile("clearing");
            MapTiles[2, 1] = new Tile("clearing");
            MapTiles[2, 2] = new Tile("clearing");

        }

        public bool CanMoveToTile(int ToX, int ToY)
        {

            return ToX >= 0 && ToX <= 2 && ToY >= 0 && ToY <= 2;
        }

        



    }
}

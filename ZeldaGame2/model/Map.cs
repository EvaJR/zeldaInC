using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame2.model
{
    class Map
    {
        // 2D array containing Tile items
        public Tile[,] MapTiles { get; set; } = new Tile[6, 6];

        // TODO rewrite to a constructor setting height & width of map
        public Map()
        {

        }

        // TODO write a GenerateMap() function with Math.random
        public void BuildMap()
        {
            var forest = new Tile("You see nothing but trees around you");

            // filling a 2D array with forest // TODO same thing with random numbers
            for (int row = 0; row < 6; row++)
            {
                for (int column = 0; column < 6; column++)
                {
                    MapTiles[row, column] = forest;
                }
            }

            // overwriting a few forest tiles with special tiles

            MapTiles[3, 3] = new Tile("You are standing in a clearing in the forest");
            MapTiles[3, 2] = new Tile("You see a branch lying on the ground");
            MapTiles[4, 2] = new Tile("You find a shiny green rupee");
            MapTiles[4, 3] = new Tile("You find a shiny blue rupee");
            MapTiles[2, 3] = new Tile("You hear screaming to the west");
            MapTiles[1, 3] = new Tile("");

            // link items to tiles

            MapTiles[4, 2].HasRupee = true;
            MapTiles[4, 3].HasRupee = true;
            MapTiles[3, 2].ItemOnTile = new Item("branch");
            MapTiles[1, 3].EnemyOnTile = new Enemy("troll");
           


        }

        // check when player falls off the map (used in game controller)
        public bool CanMoveToTile(int ToX, int ToY)
        {
            // TODO use MapTiles length here for maxvalue
            return ToX >= 0 && ToX < 6 && ToY >= 0 && ToY < 6;
        }

    }
}

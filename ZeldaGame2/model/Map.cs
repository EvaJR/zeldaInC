using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame2.model
{
    class Map
    {
        // 2D array containing Tile items

        public int Width { get; set; }
        public int Height { get; set; }
        public Tile[,] MapTiles { get; set; }


        //public Tile[,] MapTiles { get; set; } = new Tile[6, 6];

        // constructor setting height & width of map
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            MapTiles = new Tile[Width, Height];
        }

        // TODO write a GenerateMap() function with Math.random
        public void BuildMap()
        {
            var forest = new Tile("You see nothing but trees around you");

            // filling a 2D array with forest // TODO same thing with random numbers
            // TODO check if width/heigth at the correct loop now
            for (int row = 0; row < Height; row++)
            {
                for (int column = 0; column < Width; column++)
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
            return ToX >= 0 && ToX < Width && ToY >= 0 && ToY < Height;
        }

        public void GenerateMap()
        {
            var forest = new Tile("You see nothing but trees around you");

            // filling a 2D array with forest 
            // TODO check if width/heigth at the correct loop now
            for (int row = 0; row < Width; row++)
            {
                for (int column = 0; column < Height; column++)
                {
                    MapTiles[row, column] = forest;
                }
            }
        }

    }
}

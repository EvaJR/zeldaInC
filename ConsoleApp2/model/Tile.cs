using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame.model
{
    class Tile
    {
        public string Description { get; set; }

        public bool HasSword { get; set; }

        public Item ItemOnTile { get; set; }

        // public List<Enemy> EnemiesOnTile { get; set; }

        public Tile (string Description)
        {
            this.Description = Description;
        }

        public Tile(string Description, Item ItemOnTile)
        {
            this.Description = Description;
            this.ItemOnTile = ItemOnTile;
        }
    }
}

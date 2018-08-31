using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame2.model
{
    class Tile
    {
        public string Description { get; set; }
        public bool HasRupee { get; set; }
        
        public Item ItemOnTile { get; set; }
        public Enemy EnemyOnTile { get; set; }

        public Tile (string description)
        {
            Description = description;
        }

        public void Print()
        {
            Console.WriteLine(Description);
        }
    }
}

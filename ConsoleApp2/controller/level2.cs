using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame.controller
{
    class Level2
    {
        public void PlayLevel(Player player1)
        {

            Console.WriteLine("You follow the girl to a cave");

            Map level2 = new Map();
            var level2Map = level2.BuildMap();

            for (int k = 0; k < level2Map.GetLength(0); k++)
                for (int l = 0; l < level2Map.GetLength(1); l++)
                    Console.WriteLine(level2Map[k, l].Description);

            bool SwordInCave = true;

            while (player1.playing)
            {
                Console.WriteLine("Where do you want to go?");
                string UserInput2 = Console.ReadLine();
                player1.Move(UserInput2);

                

            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame.model;

namespace ZeldaGame.controller
{
    class Level2
    {

        public event EventHandler FoundSword;

        protected virtual void OnFoundSword(EventArgs e)
        {
            FoundSword?.Invoke(this, e);
        }

        

        public void PlayLevel(Player player1)
        {
            // subscription (bit weird because event is also here ... ?)
            this.FoundSword += player1.EquipSword;

            Console.WriteLine("You follow the girl to a cave");

            // drop player at girl standing in cave (default position: 1,1)
            player1.CoordinateY = 0;

            bool SwordInCave = true;

            




            while (player1.playing)
            {
                // build level 2 map and write Tile description where player is located
                Map level2 = new Map();
                var level2Map = level2.BuildMap();

                // test map contents:
                /*
                for (int k = 0; k < level2Map.GetLength(0); k++)
                    for (int l = 0; l < level2Map.GetLength(1); l++)
                        Console.WriteLine(level2Map[k, l].Description);
               */

                

                Console.WriteLine(level2Map[player1.CoordinateX, player1.CoordinateY].Description);
                Console.WriteLine("You are currently at position " + player1.CoordinateX + "," + player1.CoordinateY);
                // TODO: write try catch block, throwing a FallOfTheMapException

                Console.WriteLine("Where do you want to go?");
                string UserInput2 = Console.ReadLine();
                player1.Move(UserInput2);

                if (level2Map[player1.CoordinateX, player1.CoordinateY].HasSword)
                {

                    OnFoundSword(null);
                }

                



            }

            Console.ReadLine();

        }



    }
}

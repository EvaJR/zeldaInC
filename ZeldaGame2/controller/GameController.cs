using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame2.model;

namespace ZeldaGame2.controller
{
    class GameController
    {
        public Player Player { get; set; }
        public Map Map { get; set; }
        public bool Playing { get; set; } = true;
        Tile CurrentTile { get; set; }

        public void Start()
        {

            Player = new Player(0, 0);
            Map = new Map();
            Map.BuildMap();
            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
            CurrentTile.Print();

            Run();

        }

        public void Run()
        {
            while(Playing)
            {
                var input = Console.ReadLine().ToLower();

                switch(input)
                {
                    case ("north"):
                        if(Map.CanMoveToTile(Player.CoordinateX, Player.CoordinateY - 1))
                        {
                            Player.CoordinateY--;
                            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
                            CurrentTile.Print();
                        }
                        else
                        {
                            Console.WriteLine("You can't go there");
                        }
                        break;
                    case ("south"):
                        if (Map.CanMoveToTile(Player.CoordinateX, Player.CoordinateY + 1))
                        {
                            Player.CoordinateY++;
                            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
                            CurrentTile.Print();
                        }
                        else
                        {
                            Console.WriteLine("You can't go there");
                        }
                        break;
                    case ("west"):
                        if (Map.CanMoveToTile(Player.CoordinateX - 1, Player.CoordinateY))
                        {
                            Player.CoordinateX--;
                            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
                            CurrentTile.Print();
                        }
                        else
                        {
                            Console.WriteLine("You can't go there");
                        }
                        break;
                    case ("east"):
                        if (Map.CanMoveToTile(Player.CoordinateX + 1, Player.CoordinateY))
                        {
                            Player.CoordinateX++;
                            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
                            CurrentTile.Print();
                        }
                        else
                        {
                            Console.WriteLine("You can't go there");
                        }
                        break;
                    case ("quit"):
                        End();
                        break;
                    default:
                        Console.WriteLine("Huh?");
                        break;

                }
                    

            }

        }

        public void End()
        {
            Console.WriteLine("Bye!");
        }
    }
}

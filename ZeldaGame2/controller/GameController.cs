using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZeldaGame2.model;

namespace ZeldaGame2.controller
{   
    // class which controls gameflow
    class GameController
    {

        // declare classes to control from this class
        public Player Player { get; set; }
        public Map Map { get; set; }
        Tile CurrentTile { get; set; }

        // boolean for in while loop to keep playing game
        public bool Playing { get; set; } = true;

        public void Start()
        {

            // welcome
            Ocarina Ocarina = new Ocarina();

            // play music during asking player name (thread)
            Task.Run(() => Ocarina.PlayZeldaTune());

            // new player with initial x,y coordinates
            Player = new Player(3, 3);

            void AskPlayerName()
                {
                    Console.WriteLine("Hello, what's your name?");
                    string UserInput = Console.ReadLine();
                    if (UserInput == " " || UserInput == "")
                    {
                        Console.WriteLine("Please enter a name");
                        AskPlayerName();
                    }
                    else if (UserInput.Length > 20)
                    {
                        Console.WriteLine("Your name is too long");
                        AskPlayerName();
                    }
                    else
                    {
                        Player.Name = (UserInput); // C# version of set.}

                    }
                }

                AskPlayerName();

                Console.WriteLine("Welcome to the game " + Player.Name);

            // map with tiles
            Map = new Map();
            Map.BuildMap();

            // define current tile and print description
            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
            CurrentTile.Print();

            Run();

        }

        public void Run()
        {
            while(Playing)
            {
                // user input, caps insensitive
                var input = Console.ReadLine().ToLower();

                switch(input)
                {
                    // TODO: write Move function to DRY
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

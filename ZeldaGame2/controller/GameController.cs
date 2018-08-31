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

            // play music during asking player name (thread) Thanks Hielke!
            Task.Run(() => Ocarina.PlayZeldaTune());

            // new player with initial x,y coordinates: randomize?
            
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

            Console.WriteLine("Choose a gametype " + Player.Name);
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Chaos");
            string UserChoice = Console.ReadLine();

            if (UserChoice == "1")
             {
                Console.WriteLine("Starting game in normal mode...");
                NormalGame();
             } else
            {
                Console.WriteLine("Starting game in CHAOS mode...");
                ChaosGame();
            }


        }

        public void NormalGame()
        {
            // map with tiles: set width and height
            Map = new Map(6, 6);
            Map.BuildMap();

            // define current tile and print description
            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
            CurrentTile.Print();

            Run();
        }

        public void ChaosGame()
        {
            Random random = new Random();
            int width = random.Next(1, 11); // creates a number between 1 and 10
            int height = random.Next(1, 11);

            Map = new Map(width, height);
            Map.GenerateMap();
            Player.CoordinateX = 0;
            Player.CoordinateY = 0;

            // define current tile and print description
            CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
            CurrentTile.Print();
            Console.WriteLine("You are on a map of "+ Map.Height + "x " + Map.Width);

            Run();

        }


        public void Run()
        {
            while(Playing)
            {
                Console.WriteLine("Where do you want to go?");
                // user input, caps insensitive
                var input = Console.ReadLine().ToLower();

                switch(input)
                {
                    case ("north"):
                        Move(0, -1);
                        break;
                    case ("south"):
                        Move(0, 1);
                        break;
                    case ("west"):
                        Move(-1, 0);
                        break;
                    case ("east"):
                        Move(1, 0);
                        break;
                    case ("i"):
                        Player.ShowInventory();
                        break;
                    case ("e"):
                        if (Player.Inventory.Count > 0)
                        { Player.EquipWeapon(); }
                        else
                        { Console.WriteLine("No weapons to equip"); }
                        break;
                    case ("quit"):
                        End();
                        break;
                    default:
                        Console.WriteLine("Huh? Did you mean north, south, east or west?");
                        break;

                }

                if(CurrentTile.HasRupee)
                {
                    Player.RupeeTotal++;
                    CurrentTile.HasRupee = false;
                    CurrentTile.Description = "";
                }

                if(CurrentTile.ItemOnTile != null)
                {
                    Player.Inventory.Add(CurrentTile.ItemOnTile);
                    CurrentTile.ItemOnTile = null;
                    CurrentTile.Description = "";
                }

                if(CurrentTile.EnemyOnTile != null)
                {
                    Console.WriteLine("A " + CurrentTile.EnemyOnTile.Name + " appears!");
                    if(Player.EquippedWeapon == null)
                    {
                        Console.WriteLine("You have nothing to protect yourself!");
                        Console.WriteLine("GAME OVER");
                        End();
                    }
                    else
                    {
                        Console.WriteLine("You attack the " + CurrentTile.EnemyOnTile.Name + " with " + Player.EquippedWeapon.Name);
                    }

                }
                    

            }

        }

        public void End()
        {
            Console.WriteLine("Bye!");
            Playing = false;
            Console.ReadLine();
        }

        public void Move(int deltaX, int deltaY)
        {
            if (Map.CanMoveToTile(Player.CoordinateX + deltaX, Player.CoordinateY + deltaY))
            {
                Player.CoordinateY += deltaY;
                Player.CoordinateX += deltaX;
                CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
                CurrentTile.Print();
            }
            else
            {
                Console.WriteLine("You can't go there");
            }
        }

    }
}

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
                Console.WriteLine("Where do you want to go?");
                // user input, caps insensitive
                var input = Console.ReadLine().ToLower();

                switch(input)
                {
                    // TODO: write Move function to DRY
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
                        //if (Map.CanMoveToTile(Player.CoordinateX + 1, Player.CoordinateY))
                        //{
                        //    Player.CoordinateX++;
                        //    CurrentTile = Map.MapTiles[Player.CoordinateX, Player.CoordinateY];
                        //    CurrentTile.Print();
                        //}
                        //else
                        //{
                        //    Console.WriteLine("You can't go there");
                        //}
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

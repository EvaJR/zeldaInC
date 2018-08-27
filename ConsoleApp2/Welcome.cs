﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame
{
    class Welcome
    {
        public void WelcomeText(Player player1)
        {
            void AskPlayerName()
            {
                Console.WriteLine("Hello, what's your name?");
                string UserInput = Console.ReadLine();
                if (UserInput == " " || UserInput == "")
                {
                    Console.WriteLine("Please enter a name");
                    AskPlayerName();
                }
                else
                {
                    player1.Name = (UserInput); // C# version of set.}

                }
            }

            AskPlayerName();

            Console.WriteLine("Welcome to the game " + player1.Name);
        }

   
    }
}

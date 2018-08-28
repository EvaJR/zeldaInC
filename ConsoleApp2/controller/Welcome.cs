
using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame.model;

namespace ZeldaGame
{
    class Welcome
    {
        public void WelcomeText(Player player1)
        {
            Ocarina test = new Ocarina();
            test.PlayMaryHadALittleLamb();
            


            void AskPlayerName()
            {
                Console.WriteLine("Hello, what's your name?");
                string UserInput = Console.ReadLine();
                if (UserInput == " " || UserInput == "")
                {
                    Console.WriteLine("Please enter a name");
                    AskPlayerName();
                }

                else if (UserInput.Length > 20 )
                {
                    Console.WriteLine("Your name is too long");
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

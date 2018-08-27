
using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame
{
    class Welcome
    {
        public void WelcomeText()
        {
            // Welcome player, choose a name
            Console.WriteLine("Hello, what's your name?");
            string UserInput = Console.ReadLine();

            var player1 = new Player();
            player1.Name = (UserInput); // C# version of set.

            Console.WriteLine("Welcome to the game " + player1.Name);
        }

   
    }
}

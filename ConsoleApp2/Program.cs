using System;

namespace ZeldaGame
{
    class Program
    {

        static void Main(string[] args)
        {
            // Welcome player, choose a name
            var player1 = new Player();

            var welcome = new Welcome();
            welcome.WelcomeText(player1);

            var level1 = new Level1();
            level1.PlayLevel1(player1);

        }
    }
}

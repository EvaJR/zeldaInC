using System;
using ZeldaGame.controller;
using ZeldaGame.view;

namespace ZeldaGame
{
    class Program
    {

        static void Main(string[] args)
        {

            // *** test MVC model player


            ////var view = new PlayerView();

            ////var controller = new PlayerController(player, view);

            ////controller.UpdateView();


            // Welcome player, choose a name
            var player1 = new Player();

            var view = new PlayerView();

            var playerController = new PlayerController(player1, view);


            var welcome = new Welcome();
            welcome.WelcomeText(player1);

            var level1 = new Level1();
            level1.PlayLevel1(player1);

            var level2 = new Level2();
            level2.PlayLevel(player1);



        }
    }
}

using System;
using ZeldaGame.controller;
using ZeldaGame.view;

namespace ZeldaGame
{
    class Program
    {

        static void Main(string[] args)
        {

            // test GameController class

            var player = new Player();
            var welcome = new Welcome() ;
            var level1 = new Level1();
            var level2 = new Level2();
    

        var gameController = new GameController(player, welcome, level1, level2);
            gameController.PlayGame();



            // Welcome player, choose a name
            //var player1 = new Player();

            //var view = new PlayerView();

            //var playerController = new PlayerController(player1, view);


            //var welcome = new Welcome();
            //welcome.WelcomeText(player1);

            //var level1 = new Level1();
            //level1.PlayLevel1(player1);

            //var level2 = new Level2();
            //level2.PlayLevel(player1);



        }
    }
}

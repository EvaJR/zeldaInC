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



        }
    }
}

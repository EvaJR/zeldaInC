using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame.controller
{
    class GameController
    {
        private Player player;
        private Welcome welcome;
        private Level1 level1;
        private Level2 level2;
        private Map map;

        public GameController(Player player, Welcome welcome, Level1 level1, Level2 level2)
        {
            this.player = player;
            this.welcome = welcome;
            this.level1 = level1;
            this.level2 = level2;
        }

        public void WelcomePlayer()
        {
            welcome.WelcomeText(player);
        }

        public void PlayLevel1()
        {
            level1.PlayLevel1(player);
        }

        public void PlayLevel2()
        {
            level2.PlayLevel(player);
        }

        public void PlayGame()
        {
            WelcomePlayer();
            PlayLevel1();
            PlayLevel2();
        }




    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame.view
{
    class PlayerView
    {
        public void ShowPlayerDetails(Player player)
        {
            Console.WriteLine(player.ToString() + "Name: " +  player.Name);
        }
    }
}

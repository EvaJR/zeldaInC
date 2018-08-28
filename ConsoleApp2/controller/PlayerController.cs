using System;
using System.Collections.Generic;
using System.Text;
using ZeldaGame.view;

namespace ZeldaGame.controller
{
    class PlayerController
    {
        private Player model;
        private PlayerView view;

        public PlayerController(Player model, PlayerView view)
        {
            this.model = model;
            this.view = view;
        }

        public void UpdateView()
        {
            view.ShowPlayerDetails(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame.model
{
    class FindSword
    {
        public event EventHandler FoundSword;

        protected virtual void OnFoundSword(EventArgs e)
        {
            FoundSword?.Invoke(this, e);
        }


    }
}

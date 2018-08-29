using System;
using System.Collections.Generic;
using System.Text;

namespace ZeldaGame.model
{
    class FallOfTheMapException : Exception
    {

        public FallOfTheMapException()
        {
        }

        public FallOfTheMapException(string message)
            : base(message)
        {
        }

        public FallOfTheMapException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}

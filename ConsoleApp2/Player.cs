using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Player
    {
        // private string Name { get; set; }
        private string Name;

        public string GetName ()
        {
            return Name;
        }

        public void SetName (string Name)
        {
            this.Name = Name;
        }

    }
}

using SpaceForField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Player
    {
        public string Name {  get; set; }
        public char Side { get; set; }

        public Player(string name, char side)
        {
            Name = name;
            Side = side;
        }

    }
}

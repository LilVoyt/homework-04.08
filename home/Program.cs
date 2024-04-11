using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using home;
using SpaceForField;

namespace home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new Field(4), new User("Oleg", 'x'), new Bot("Marek", '0'));
            game.startGame();
        }
    }
}


using SpaceForField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    public class Player
    {
        public string Name {  get; set; }
        public char Side { get; set; }

        public Player(string name, char side)
        {
            Name = name;
            Side = side;
        }
        public virtual (int, int) Attack()
        {
            return (0, 0);
        }
    }

    public class Bot : Player
    {
        public Bot(string name, char side) : base(name, side)
        {
            Name = name;
            Side = side;
        }

        public override (int, int) Attack()
        {
            Random random = new Random();
            int x = random.Next(0, 3);
            int y = random.Next(0, 3);
            return (x, y);
        }
    }
    public class User : Player
    {
        public User(string name, char side) : base(name, side)
        {
            Name = name;
            Side = side;
        }

        public override (int, int) Attack()
        {
            Console.Write("Enter x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter x:");
            int y = int.Parse(Console.ReadLine());
            return (x, y);
        }
    }
}

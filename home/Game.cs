using SpaceForField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    internal class Game
    {
        public Field field;
        public  Player player1;
        public Player player2;

        public Game(Field field, Player player1, Player player2)
        {
            this.field = field;
            this.player1 = player1;
            this.player2 = player2;
        }
        public void Move(Player player, Field field)
        {
            (int x, int y) = player.Attack();
            ref char cell = ref field.SetSign(x, y);
            cell = player.Side;
        }

        public void startGame()
        {
            Console.WriteLine("This is start of the game: ");
            field.Print();
            int count = 0;
            while (count < 10)
            {
                if(count % 2 == 0)
                {
                    Move(player1, field);
                    field.Print();
                    count++;
                }
                else if(count % 2 != 0)
                {
                    Move(player2, field);
                    field.Print();
                    count++;
                }
            }
        }
    }
}

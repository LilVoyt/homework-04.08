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
        public void Move(Player player, int x, int y, Field field)
        {
            ref char cell = ref field.SetSign(0, 0);
            cell = player.Side;
        }

        public void startGame()
        {
            field.Print();
            while (field.IsGameOver())
            {
                Move(player1, 2, 2, field);
                field.Print();
            }
        }
    }
}

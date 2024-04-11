using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceForField
{
    internal class Field
    {
        char[,] battleField;
        private int size;

        private int sizeProp
        {
            get { return size; }
            set {
                if (value < 3) {
                    size = 3;
                    Console.WriteLine($"Size {value} is not correct, size changed to {size}");
                }
                else if (value >= 3 && value <= 10) {
                    size = value;
                    Console.WriteLine($"Size now is {size}!");
                }
                else if (value > 10) {
                    size = 10;
                    Console.WriteLine($"Size {value} is not correct, size changed to {size}");
                }
            }
        }

        public Field(int size) {
            this.sizeProp = size;
            this.battleField = new char[this.size, this.size];
            Init();
        }

        private void Init()
        {
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    battleField[i, j] = ' ';
                }
            }
        }

        public void Print()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{battleField[i, j]}{(j == size - 1 ? "" : " ")}");
                }
                Console.WriteLine("|");
            }
        }

        public ref char SetSign(int x, int y)
        {
            return ref battleField[x, y];
        }


        public bool IsGameOver()
        {
            for (int i = 0; i < battleField.GetLength(0); i++)
            {
                if (battleField[i, 0] != ' ' && battleField[i, 0] == battleField[i, 1] && battleField[i, 1] == battleField[i, 2])
                {
                    return true;
                }
            }

            for (int j = 0; j < battleField.GetLength(1); j++)
            {
                if (battleField[0, j] != ' ' && battleField[0, j] == battleField[1, j] && battleField[1, j] == battleField[2, j])
                {
                    return true;
                }
            }

            if (battleField[0, 0] != ' ' && battleField[0, 0] == battleField[1, 1] && battleField[1, 1] == battleField[2, 2])
            {
                return true; 
            }

            if (battleField[0, 2] != ' ' && battleField[0, 2] == battleField[1, 1] && battleField[1, 1] == battleField[2, 0])
            {
                return true; 
            }

            for (int i = 0; i < battleField.GetLength(0); i++)
            {
                for (int j = 0; j < battleField.GetLength(1); j++)
                {
                    if (battleField[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

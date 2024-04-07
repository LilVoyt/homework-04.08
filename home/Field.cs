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
            this.size = size;
            this.battleField = new char[size, size];
            Init();
        }

        private void Init()
        {
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    battleField[i, j] = '+';
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

    }
}

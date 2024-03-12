using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray = new int[10,6];

            Random random = new Random();

            for (int i = 0; i < MyArray.GetLength(0); i++) 
            {
                for (int j = 0; j < MyArray.GetLength(1); j++) 
                {
                    MyArray[i, j] = random.Next(250); //Генерирует рандомные числа!
                }
                
            }

            for (int y = 0; y < MyArray.GetLength(0); y++) 
            {
                for (int x = 0; x < MyArray.GetLength(1) ; x++) 
                {
                    Console.Write(MyArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray = new int[3, 3];



            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y:" + i + " X: " + j);
                    MyArray[i, j] = int.Parse(Console.ReadLine()); //Отвечает за ввод 
                }

            }
            Console.WriteLine();
            for (int y = 0; y < MyArray.GetLength(0); y++)
            {
                for (int x = 0; x < MyArray.GetLength(1); x++)
                {
                    Console.Write(MyArray[y, x] + "\t");
                }
                Console.WriteLine();

            }
        }
    }   }  

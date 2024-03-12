using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_33._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,,] myArray = new int[4, 3, 5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j  = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(150);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page №: " + (i - 1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

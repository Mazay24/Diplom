using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[][][] myArray = new int[random.Next(3, 6)][][];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[random.Next(2, 6)][];

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[random.Next(2, 6)];
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = random.Next(150);
                    }
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Page №: " + (i + 1));
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

        
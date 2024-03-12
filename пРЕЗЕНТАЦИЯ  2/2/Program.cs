using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 0;
            int L = 0;
            int sum = 0;
            int[,] R = new int[,]
            {
                {5, 12, -8, 9, 7},
                {9, 11, 27, 14, 72 },
                {21, 15, 0, 80, 55},
                {3, 77, 89, 34, 25},
                {40, 30, 22, 31, 0}
            };


            for (int i = 0; i < R.GetLength(0); i++)
            {
                for (int j = 0; j < R.GetLength(1); j++)
                {
                    sum = sum + R[i, j];
                }
                L = Math.Max(sum, 0);
                Console.WriteLine(sum);

                sum = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < R.GetLength(1); i++)
            {
                for (int j = 0; j < R.GetLength(0); j++)
                {
                    sum = sum + R[j, i];
                }
                Console.WriteLine(sum);
                K = Math.Max(sum, 0);
                sum = 0;
            }
        }
    }
}

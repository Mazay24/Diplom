using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумер_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //В данной целочисленной квадратной матрице А(5,5) указать индексы всех элементов, имеющих наибольшее значение.
            
            {
                var schet1 = 0;
                var schet2 = 0;

                int[,] gg = new int[,]
                {
{5, 12, -8, 6, 8},
{9, 11, 27, 11, 12 },
{21, 15, 29, 12, 111},
{12, 123, 111, 141, 11 },
{64, 34, 33, 121, 133 }
                };

                int Max = gg[0, 0];
                for (int i = 0; i < gg.GetLength(0); i++)
                {
                    schet1 = i + 1;

                    for (int j = 0; j < gg.GetLength(1); j++)
                    {
                        schet2 = j;
                        if (gg[i, j] > Max)
                        {
                            Max = gg[i, j];

                            Console.WriteLine(Max);
                            Console.WriteLine("[" + i + "," + j + "]");

                        }

                    }

                }
            }
        }
    }
}
    


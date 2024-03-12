using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана квадратная целочисленная матрица F(m, m).Найти суммы элементов тех строк,
            //имеющих четные элеметы на главной диагонали.
            int sum = 0;
            int k = 0;
            int[,] gg = new int[,]
            {
{5, 12, 6, 8},
{11, 27, 11, 12 },
{21, 12, 20, 15},
{12, 123, 141, 60 },
            };
            for (int i = 0; i < gg.GetLength(0); i++)
            {
                for (int j = 0; j < gg.GetLength(1); j++)
                {
                    if (gg[i, j] % 2 == 0 & i == j)
                    {
                        k = k + gg[i, j];



                    }


                }
            }
            Console.WriteLine(k);
        }
    }
}
        
    


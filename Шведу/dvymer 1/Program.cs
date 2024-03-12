using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvymer_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана матрица В(l,p).Определить сумму элементов, кратных 3, и количество отрицательных элементов.
            int summa = 0;
            int schet = 0;
            int[,] gg = new int[,]
            {
                {5, 12, -8},
                {9, 11, 27 },
                {21, 15, 24}
            };
            for (int i = 0; i < gg.GetLength(0); i++)
            {
                          
                for (int j = 0; j < gg.GetLength(1); j++)
                {
                    if (gg[i,j] % 3 == 0)
                    { 
                        summa = summa + gg[i, j];
                       
                    }
                    if (gg[i,j] < 0 )
                    {
                        schet++;
                    }
                  
                    
                }
               
            }
            Console.WriteLine("сумма = " + summa);
            Console.WriteLine("кол-во отрицательных элментов = " + schet);

        }
    }
}

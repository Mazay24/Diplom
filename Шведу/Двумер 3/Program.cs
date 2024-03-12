using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумер_3
{
    class Program
    {
     



    
           

    

      

        

            static void Main(string[] args)

            {
                //Заполнить квадратную матрицу В(10,10) единицами в шахматном порядке,
                //начиная с верхнего левого угла. Соседние клетки заполнить нулями.
                int zxc = 10;

                int[,] gg = new int[zxc, zxc];

                for (int i = 0; i < gg.GetLength(0); i++)

                {

                    for (int j = 0; j < gg.GetLength(1); j++)

                    {

                        gg[i, j] = (i + j) % 2 == 0 ? 1 : 0;

                        Console.Write(gg[i, j] + " ");

                    }

                    Console.WriteLine();

                }

            }

        }

    }

    


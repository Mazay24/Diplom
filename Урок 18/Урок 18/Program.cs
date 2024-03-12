using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;  i <= 3; i++)
            {
                Console.WriteLine("Цикл 1 интерация №: " + i);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("\tцикл 2 интерация №: " + j);

                    for (int k = 1; k <= 2; k++)
                    {
                        Console.WriteLine("\t\tцикл 3 интерация №: " + k);
                    }
               
                }



            }

        }
    }
}

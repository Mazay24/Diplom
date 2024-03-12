using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_36
{
    class Program
    {/// <summary>
    /// Создает сумму двух чисел
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
        static int Sum(int a, int b) //Создание метода 1
        {
            return a + b;
        }

        static int Sum(int a, int b, int c) //Создание метода 2
        {
            return a + b + c;
        }

        static double Sum(double a, double b) //Создание метода 3
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            int result = Sum(5, 7); //Выполняем действия где 2 целых числа!                                
            Console.WriteLine(result);

            int result2 = Sum(14, 5, 9); //Выполняем действия где 3 целых числа!     
            Console.WriteLine(result2);

            double result3 = Sum(2.4, 3.7); //Выполняем действия где 2 дробных числа!     
            Console.WriteLine(result3);
         
        }
    }
}

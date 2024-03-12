using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 26, 78, 24, 14, 5, 55, 199 };

            Console.WriteLine(myArray.Max()); //Вывод максимального числа из массива
            Console.WriteLine(myArray.Min()); //Вывод минимального числа из массива
            Console.WriteLine(myArray.Sum()); //Сумма всех чисел массива
            Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum()); //Сумма всех четных чисел массива
            Console.WriteLine(myArray.Where(i => i % 2 != 0).Min()); //Минимальное нечетное число 
            

        }
    }
}

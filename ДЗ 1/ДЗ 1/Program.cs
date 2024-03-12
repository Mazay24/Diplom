using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second; //Задаем тип данных 

            Console.WriteLine("Ведите первое число: "); //Просим пользователя вести данные!
            first = double.Parse(Console.ReadLine()); //Пользователь вводит данные!

            Console.WriteLine("Ведите второе число: ");
            second = double.Parse(Console.ReadLine());

            Console.WriteLine("Среднее арифмитическое двух чисел = " + (first + second) / 2); //Выводим данные
            / Можно было задать отдельную переменную для выполнения действия но я не стал!
              
            
          



        }
    }
}

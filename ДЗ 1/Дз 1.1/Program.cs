using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third; //Задаем тип данных 

            Console.WriteLine("Ведите первое число: "); //Просим пользователя вести данные!
            first = double.Parse(Console.ReadLine()); //Пользователь вводит данные!

            Console.WriteLine("Ведите второе число: ");
            second = double.Parse(Console.ReadLine());

            Console.WriteLine("Ведите третье число: ");
            third = double.Parse(Console.ReadLine());

            double sum = first + second + third;
            double result = first * second * third;

            Console.WriteLine("Сумма трёх чисел : " + sum); //Выводим ответы!
            Console.WriteLine("Произведение трёх чисел : " + result);


        }
    }
}

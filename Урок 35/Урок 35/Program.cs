using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_35
{
    class Program
    {
        static int Sum(int a, int b) //Создаём метод вводим тип данных для метода
                                     //и для переменных входящих в этот метод
        {
            int result = a + b;

            return result; //Это то что мы хотим вернуть!
        }

        static void Print(int result)
        {
            Console.WriteLine("Результат сложения: " + result);
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);
            Print(c);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_17
{
    class Program
    {
        static int Foo(int value)
        {
            if (value < 10)
                return value;

            int digit = value % 10;//Дает нам последнюю цифру числа!!!
            int nextValue = value / 10;// Убирает последнюю цифру числа!!!

            return digit + Foo(nextValue);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите число от 11 включая его: ");
            int chislo = int.Parse(Console.ReadLine());

           int result = Foo(chislo);

            Console.WriteLine("Сумма цифр числа: " + result);
        }
    } }

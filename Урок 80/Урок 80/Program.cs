using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_80
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 14;
            double b = 55;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");

            Console.WriteLine("\n");

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            Swap(ref a, ref b);
            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            int result1 = Foo<int>();
            string result2 = Foo<string>();
            Console.WriteLine(result1);
            Console.WriteLine(result2);//тут null!
        }
        static void Swap<T>(ref T a, ref T b)  //<T> - создаётся обощение
        {   T temp = a;
            a = b;
            b = temp;
        }
        static T Foo<T>()
        {
            return default;//Возвращает дефолтное значение в int это 0, в string это null!
        }
    }
}

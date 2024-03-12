using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_48._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            a += 1;//Переполнение через верхнюю границу!!!
            Console.WriteLine(a);

            int b = int.MinValue;
            b = b - 1;//Переполнение через нижнюю границу!!!
            Console.WriteLine(b);
        }
    }
    
}

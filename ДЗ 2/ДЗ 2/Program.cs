using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число : ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }


        }
    }
}

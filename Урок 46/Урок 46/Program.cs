using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_46
{
    class Program
    {
        static int Sum(params int[] ment) //Позволяет передать любое количество параметров!
        {
            int result = 0;
            for (int i = 0; i < ment.Length; i++)
            {
                result += ment[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(5, 15, 42, 7, 14);

            Console.WriteLine(result);
        }
    }
}

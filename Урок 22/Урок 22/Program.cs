using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int result = a + b;
            int result1 = a - b;
            int result2 = a * b;
            double c = Convert.ToDouble(a);
            double d = Convert.ToDouble(b);
            double result3 = c / d;
            double result4 = c % d;
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            int t = result * result2 - result1;
            Console.WriteLine(t);
            
            
        }
    }
}

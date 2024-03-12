using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_48._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(a)); //output: True

            double b = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(b)); //output: True

            double c = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(c)); //output: True

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a++;
            a++;
            Console.WriteLine(--a);

            int b = 1;
            b = ++b * b;
            Console.WriteLine(b);

        }
    }
}

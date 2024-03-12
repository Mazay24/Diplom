using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_38
{
    class Program
    {
        static void Foo(int a)
        {
            a = 5;
        }

        static void Bar(int[] arr)
        {
            arr[0] = 5;
        }

        static void Main(string[] args)
        {
            int a = 1;
            Foo(a);
            Console.WriteLine(a);

            int[] b = new int[1];
            Bar(b);
            Console.WriteLine(b[0]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_39
{
    class Program
    {
        static void Foo()
        {
            int[] b = new int[15]; 
        }

        static void Main(string[] args)
        {
            int[] a;
            a = new int[10];
            a = null;

            Foo();

        }
    }
}

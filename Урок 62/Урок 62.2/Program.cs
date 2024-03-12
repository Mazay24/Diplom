using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_62._2
{
    class MyClass
    {
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
        public static void Bar()
        {
            Console.WriteLine("Bar");
            Console.WriteLine(a);
        }
        public static int a = 14;
        class Program
        {
            static void Main(string[] args)
            {
                MyClass.Foo();
                MyClass.Bar();

            }
        }
    }
}

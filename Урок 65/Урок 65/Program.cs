using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_65
{
    class MyClass
    {
        public const string MY_ERROR = "some error";
        public readonly int _a;
        public static readonly int _b;
        public MyClass(int a)
        {
            _a = a;

        }
        static MyClass()
        {
            _b = 14;
        }
        public void Print()
        {
            Console.WriteLine(MY_ERROR);
            Console.WriteLine(_a);
            Console.WriteLine(_b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass(55);
            myclass.Print();
        }
    }
}

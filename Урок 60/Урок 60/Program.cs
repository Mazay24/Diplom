using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_60
{
    class MyClass
    {
        public int a;
        public static int b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.b = 4;// Не надо создвать объект класса!

            MyClass myClass1 = new MyClass();
            myClass1.a = 14;
            MyClass myClass2 = new MyClass();
            myClass2.a = 55;
        }
    }
}

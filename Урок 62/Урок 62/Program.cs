using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_62
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Конструктор");
        }
        static MyClass()//Всегда вызывается перед обычным конструктором и только 1 раз!
        {
            Console.WriteLine("Стытический конструктор");
        }
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            new MyClass();
            new MyClass();
            new MyClass();

            MyClass.Foo();
        }
    }
}

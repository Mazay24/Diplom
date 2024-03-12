using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_61
{
    class MyClass
    {
      private static int a;
    
        public static void Foo()
        {
            Console.WriteLine("Вызван метод Foo");
            a = 14;
            Console.WriteLine(a);
        } 
        public void Bar()
        {
            Console.WriteLine("Вызван метод Bar");
            Console.WriteLine(a);
            Foo();
        }
        public static int B { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass.Foo();
            myClass.Bar();
            MyClass.B = 55;
            Console.WriteLine(MyClass.B);
        }
    }
}

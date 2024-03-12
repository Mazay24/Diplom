using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_61._2
{
    class MyClass
    {
        public MyClass()
        {
            counter++;
        }
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }
        public int HC
        {
            get { return counter; }
            
        }
        public static int GetCounter()
        {
            return counter;
        }
        public int Skam()
        {
            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            Console.WriteLine(myClass1.HC);
            MyClass myClass2 = new MyClass();
            Console.WriteLine(myClass1.Skam());
            MyClass myClass3 = new MyClass();
            Console.WriteLine(MyClass.Counter);
            Console.WriteLine(MyClass.GetCounter());
            
        }
    }
}

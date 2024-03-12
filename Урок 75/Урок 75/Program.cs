using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_75
{
    interface IFirst
    {
        void Action();
    }
    interface ISecond
    {
        void Action();
    }
    class MyClass : IFirst, ISecond
    {
        public void Action()
        {
            Console.WriteLine("MyClass Action...");
        }
    }
    class MyOtherClass : IFirst, ISecond
    {
        void IFirst.Action()
        {
            Console.WriteLine("MyOtherClass IFirst.Action...");
        }

        void ISecond.Action()
        {
            Console.WriteLine("MyOtherClass ISecond.Action...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Foo(myClass);
            Bar(myClass);
            Console.WriteLine();
            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass);
            Bar(myOtherClass);
            Console.WriteLine();
            IFirst first = myOtherClass;
            first.Action();
            Console.WriteLine();
            ((ISecond)myOtherClass).Action();
        }
        static void Foo(IFirst first)
        {
            first.Action();
        }
        static void Bar(ISecond second)
        {
            second.Action();
        }
    }
}

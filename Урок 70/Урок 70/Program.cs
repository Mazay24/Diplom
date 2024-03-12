using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_70
{
    class A
    {
        public int pubA;
        private int privA;
        protected int protA;

        public A()
        {
            Console.WriteLine(pubA);//Можем получить доступ!
            Console.WriteLine(privA);//Можем получить доступ!
            Console.WriteLine(protA);//Можем получить доступ!
        }
        public void Foo()
        {
            Console.WriteLine(pubA);//Можем получить доступ!
            Console.WriteLine(privA);//Можем получить доступ!
            Console.WriteLine(protA);//Можем получить доступ!
        }
    }
    class B : A //Наследование!
    {
        public B()
        {
            Console.WriteLine(pubA); //Можем получить доступ!
            //Console.WriteLine(privA);  Не можем получить доступ!
            Console.WriteLine(protA); //Можем получить доступ!
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.pubA);//Можем получить доступ!
            //Console.WriteLine(a.privA); Не можем получить доступ!
            //Console.WriteLine(a.protA); Не можем получить доступ!
            a.Foo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_44
{
    class Program
    {

        static void Foo(out int value)
        {
            value = 5;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a;
            Foo(out a);
            //Верхнии записи можно сократить Foo(out int a);
            Console.WriteLine(a);

            string str = Console.ReadLine();
            int.TryParse(str, out int chislo);
            Console.WriteLine(chislo);
        }
    }
}

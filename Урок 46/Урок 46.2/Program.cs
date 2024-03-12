using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_46._2
{
    class Program
    {
        static void Foo(params object [] papa) //object базовый тип данных
                                               //для всех типов данных!
        {
            string message = "Тип данных {0}, значение {1}";
            foreach (var item in papa)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            Foo("text", 5, "gg boys", 14, "good job", true);

            object o = 5;//Операция упаковки

        }
    }
}

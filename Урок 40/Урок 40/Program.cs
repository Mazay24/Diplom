using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_40
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            Console.WriteLine(str ?? "нет данных");/*Если str=null то будет выводится
                                                    * сообщение "нет данных"
                                                    */
            string result = str ?? string.Empty; //Присвоевает пустую строку при null.
            Console.WriteLine("Количество символов в строке: " + result.Length);

            string str2 = "text";
                Console.WriteLine(str2 ?? "нет данных");
                string result2 = str2 ?? string.Empty;
            Console.WriteLine("Количество символов в строке: " + result2.Length);
        }
    }
}

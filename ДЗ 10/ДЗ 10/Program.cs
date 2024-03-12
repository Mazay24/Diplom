using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_10
{
    class Program
    {
        static void PrintLine(string symvol, uint symvolsCount)
        {
            for (int i = 0; i < symvolsCount; i++)
            {
                Console.Write(symvol);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            string symvol = Console.ReadLine();
            Console.WriteLine("Введите количество символов: ");
            uint symvolsCount = uint.Parse(Console.ReadLine());

            PrintLine(symvol, symvolsCount);
            Console.ReadLine();
        }
    }
}

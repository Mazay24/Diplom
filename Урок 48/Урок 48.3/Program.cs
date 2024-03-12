using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_48._3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.MaxValue;
            decimal b = decimal.MaxValue;
            decimal c = unchecked(a + b);// Для этого типа арифметическое переполнение всегда
                                         // вызывает исключение!!!

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_45
{
    class Program
    {
        static void GG(in int chislo)
        {
            chislo = 7; //in нечего не даёт делать с переменной,
                        //её можно только просмотреть!
        }
        static void Main(string[] args)
        {
            int a = 5;
            GG(a); //тут in не обязательно употреблять перед a!
        }
    }
}

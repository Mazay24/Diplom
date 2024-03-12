using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_48
{
    class Program
    {
       
        
         
        static void Main(string[] args)
        {
            byte agrees = 1;
            byte democrazy = 2;
            checked
            {
                agrees = (byte)(agrees - democrazy);//Сужающее преобразование данных!!!
            }
            /* Или можно так:
             * agrees = checked(byte)(agrees - democrazy);
             * Cлово unchecked отключает проверку!!!
             */
            Console.WriteLine(agrees);
        }
    }
}

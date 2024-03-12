using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Урок_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "5";
            int a = int.Parse(str);

            string str2 = "3,14";
            double b = double.Parse(str2);

            int c;
            string str3 = "8";
            bool result = int.TryParse(str3, out c);

            if (result)
            {   
                Console.WriteLine("Операция успешно, выполнена = " + c);
            }
            else
            {
                Console.WriteLine("Не удалась конвертация!");
            }
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdTorub = 71.24; //Задаём курс
            double usdTouah = 27.1;

            Console.WriteLine("Введите сумму в USD"); //Просим вести сумму в USD

            double USD = double.Parse(Console.ReadLine()); //Пользователь водит данные!
            Console.WriteLine(USD + " USD в RUB = " + USD * usdTorub); //Выводим ответ!
            
            Console.WriteLine(USD + " USD в UAH = " + USD * usdTouah);

        }
    }
}

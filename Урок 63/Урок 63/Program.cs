using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_63
{
    static class MyClass
    {
        public static void Print(this DateTime daytime)
        {
            Console.WriteLine(daytime);
        }
        public static bool IsDay(this DateTime datetime, DayOfWeek dayWeek)
        {
            return datetime.DayOfWeek == dayWeek;
        }
    }/*Методы расширения (extension methods) позволяют добавлять новые методы в уже существующие типы без 
     *создания нового производного класса. Эта функциональность бывает особенно полезна, когда нам хочется
     *добавить в некоторый тип новый метод, но сам тип (класс или структуру) мы изменить не можем, поскольку у
     *нас нет доступа к исходному коду. Либо если мы не можем использовать стандартный механизм наследования,
     *например, если классы определенны с модификатором sealed.
      */
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            dateTime.Print();
            Console.WriteLine(dateTime.IsDay(DayOfWeek.Monday));
        }
    }
}

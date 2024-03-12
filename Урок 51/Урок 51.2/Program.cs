using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_51._2
{
    class Program
    {
        enum DayofWeek : byte //Указываем тип данных который хотим использовать!!!
        {
            Monday, //Нумерация начинается с 0!
            Thuesday,//1
            Wednesday,//2
            Thursday,//3
            Friday,//4
            Saturday,//5
            Sunday//6

        }
        static void Main(string[] args)
        {
            DayOfWeek dayofWeek = DayOfWeek.Friday;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));//получаем тип данных!!!
            Console.WriteLine(dayofWeek);
            Console.WriteLine((int)dayofWeek); //приводим DayOfWeek к int!!!
            Console.WriteLine((DayOfWeek)3); //приводим int к DayOfWeek!!!

            DayOfWeek nextDay = GetNextDay(dayofWeek);//
        }
        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;

                return DayOfWeek.Monday;
            
        }

    }
}

using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели");
            var lenght = Enum.GetNames(typeof(Day)).Length;
            for (int i = 1; i < lenght; i++)
            {
                Console.WriteLine(i + ":" +((Day)i));
            }
            Day day = (Day)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите час");
            double hour = Convert.ToByte(Console.ReadLine());

            if (hour >= 0 && hour <= 6)
            {
                Console.WriteLine("Сейчас" + day + "Ночь");
            }
            else if (hour >= 7 && hour <= 12)
            {
                Console.WriteLine("Сейчас" + day + "Утро");
            }
            else if (hour >= 13 && hour <= 18)
            {
                Console.WriteLine("Сейчас" + day + "День");
            }
            else if (hour >= 19 && hour <= 23)
            {
                Console.WriteLine("Сейчас" + day + "Вечер");
            }
            else
            {
                Console.WriteLine("Время введено неправильно");
            }
           
           
        }
    }
    enum Day
    {
        Понедельник = 1,
        Вторник = 2,
        Среда = 3,
        Четверг = 4,
        Пятница = 5,
        Суббота = 6,
        Воскресенье = 7
    }
}
    


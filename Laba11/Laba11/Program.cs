using System;

namespace Laba11
{
    class Program
    {
        enum DaysOfWeek
        { Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье }

        delegate string Days();
        static void Main(string[] args) {
            {
                string[] Day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
                int chislo = -1;

                Days days = () =>
                {
                    chislo = (chislo + 1);
                    if (chislo == 7)
                    {
                        chislo = 0;
                    }
                    
                    

                    return Day[chislo];
                };

                for (int i = 0; i < 24; i++)
                {
                    Console.WriteLine(days());
                }
            }
        }
    }
}



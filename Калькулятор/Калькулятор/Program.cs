using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                uint chet = 0; //Чётные числа
                uint nechet = 0; //Нечетные 
                int summmaChet = 0;
                int summmNechet = 0;
                Console.WriteLine("Введите первое число диапазона");
                int currentValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите последнее число диапазона");
                int limit = int.Parse(Console.ReadLine());
                while (currentValue <= limit)
                {
                    if (currentValue % 2 == 0) //Проверяем число на четность 
                    {
                        chet++; //Если оно чётное то в переменую chet добавляеться + 1
                        summmaChet += currentValue;
                    }
                    else
                    {
                        nechet++;
                        summmNechet += currentValue;
                    }
                    currentValue++;
                }
                Console.WriteLine("Кол-во нечетных чисел: " + chet);
                Console.WriteLine("Кол-во четных чисел: " + nechet);
                Console.WriteLine("Сумма четных чисел: " + summmaChet);
                Console.WriteLine("Сумма нечетных чисел: " + summmNechet);
                Console.ReadLine();
            }
        }
    }
}


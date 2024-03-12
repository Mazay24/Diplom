using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_2._0_с_if
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double first, second; //Задаём переменую
                string action;


                Console.WriteLine("Введите первое число: "); //Просим вести 1 число!
                first = double.Parse(Console.ReadLine()); //Вводим 1 число
                Console.WriteLine("Введите второе число: "); //Просим вести 2 число!
                second = double.Parse(Console.ReadLine()); //Вводим 2 число



                Console.WriteLine("Выберите операцию:+, -, *, /");
                action = Console.ReadLine(); //Пользователь вводит действия!

                if (action == "+")
                {
                    Console.WriteLine(first + second);
                }
                else if (action == "-")
                {
                    Console.WriteLine(first - second);
                }
                else if (action == "*")
                {
                    Console.WriteLine(first * second);
                }
                else if (action == "/")
                {
                    if (first == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(first / second);
                    }
                }
                else
                {
                    Console.WriteLine("Не потдерживает данную операцию!");
                }
                Console.ReadLine();
            }    
            
        }
    }
}

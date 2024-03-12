using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                double first, second; //Задаём переменую
                string action;


                Console.WriteLine("Введите первое число: "); //Просим вести 1 число!
                first = double.Parse(Console.ReadLine()); //Вводим 1 число
                Console.WriteLine("Введите второе число: "); //Просим вести 2 число!
                second = double.Parse(Console.ReadLine()); //Вводим 2 число



                Console.WriteLine("Выберите операцию:+, -, *, /");
                action = Console.ReadLine(); //Пользователь вводит действия!

                switch (action)
                {
                    case "+":
                        Console.WriteLine(first + second);
                        break; //Если это действие выполнено чтобы не выполнялись дальнейшие!
                    case "-":
                        Console.WriteLine(first - second);
                        break;
                    case "*":
                        Console.WriteLine(first * second);
                        break;
                    case "/":
                        if (first == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(first / second);
                        }
                        break;
                    default:
                        Console.WriteLine("Не потдерживает данную операцию!");
                        break;

                }
                Console.ReadLine(); //чтоб программа не закрывалась после выдачи ответа...
            }
        }
    }
}    
    


using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите количество выполняемых действий: ");
            int n = Convert.ToInt32(Console.ReadLine()); //Количество выполняемый действий.
            Console.WriteLine("Введите значение х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double Sum = 0;
            if (n < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число действий ");
            }
            else if (x <= 1)
            {
                Console.WriteLine("Не допустимые значения! ");           
            }
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    double P = Math.Pow(-1, n + 1) / (2 * n + 1) * (Math.Pow(x, 2 * n + 1));
                    Sum = Sum + P;

                    Console.WriteLine((Math.PI / 2) + Sum);
                }

                Console.WriteLine("Конечный ответ: ");
                Console.WriteLine((Math.PI / 2) + Sum);
            }
               
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_1
{
    class Program
    {
        static double Gg(int k)
        {
            int fuck = 1;
            for (int i = 1; i <= k; i++)
            {
                fuck *= i;
    
            }
            double P = 3 * Math.Exp(1) - 3 / fuck;
            return P;
        }
        static void Main(string[] args)
        {
            /*В порт в среднем приходят 3 корабля в день.Какова вероятность того,
            * что в день придет 2 корабля, 4 корабля? Вероятность вычислять по формуле: Р = 3 * е - 3 / к!.
            */
            Console.WriteLine("Введите количество кораблей");
            int k = int.Parse(Console.ReadLine());
            double vera = Gg(k);
            Console.WriteLine("Вероятность прибития " + k + " кораблей = " + vera);

        }
    }
}

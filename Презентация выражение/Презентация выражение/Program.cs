using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Презентация_выражение
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число!");
            int chislo = int.Parse(Console.ReadLine());

            int factorial = 2;   // значение факториала!
            int otvet = 0;

            for (int i = 0; i < 10; i++)
            

            
            {

                factorial += i;
                int boys = Convert.ToInt32(Math.Pow(chislo, i));

                    if (i == 2)
                    {
                        otvet += chislo - (boys / factorial);
                    }
                    else
                    {
                        otvet += (boys / factorial);
                    }
                    Console.WriteLine(otvet);
                    break;
                



            }
        }
    }
}

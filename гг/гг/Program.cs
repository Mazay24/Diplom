using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace гг
{
    class Program
    {

            static void Main(string[] args)
            {

                Console.WriteLine("Введите число: ");
                double chislo = int.Parse(Console.ReadLine());

                var fac = 2;
                double otvet = 0;
            
                for (int i = 2; i < 10; i++, i++)
                {
                
                    fac *= i;
                    int boys = Convert.ToInt32(Math.Pow(chislo, i));
                    if (i == 2)
                    {
                        otvet = chislo - (boys / fac);
                    }
                    else
                    {
                        otvet += boys / fac;
                    }
                              
                    Console.WriteLine(otvet);

            }
        }
    }
} 



          

            

        
    


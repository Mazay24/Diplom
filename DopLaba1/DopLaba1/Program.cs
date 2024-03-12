using System;

namespace DopLaba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четное число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());

            if (chislo % 2 == 0)
            {
                for (int i = 0; i < chislo; i++)
                {
                    for (int j = 0; j < chislo; j++)
                    {
                        int qq = i + j;

                        if (qq == chislo)
                        {
                            if (i / j == 1 & j == 1)
                            {
                                if (j / i == 1 & i == 1)
                                {

                                }
                                
                            }
                            
                        }
                        
                        
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не четное число");
            }

            

        }
    }
}

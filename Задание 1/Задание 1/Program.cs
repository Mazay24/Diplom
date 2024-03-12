using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int[] T = new int[] { 12, 14, -7, 8, -55, 76, -33};

            for (int i = 0; i < T.Length; i++)
            {

                if (i % 2 == 0)
                {
                    int c = i * i;
                    Console.WriteLine(c);
                }
                else
                {
                    int a = T[i] * -1;
                    Console.WriteLine(a);
                }
            }
        }
    }
}

        
    

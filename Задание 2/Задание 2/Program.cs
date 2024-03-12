using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] K = new int[30];
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                K[i] = rand.Next(-15, 15);
               
            }
            for (int j = 0; j < K.Length; j++)
            {
                if (K[j] < 0)
                Console.WriteLine(j);

                if (K[j] < 0)
                    sum = sum + 1;
                Console.WriteLine(sum);








            }
            
            
        }
    }
}

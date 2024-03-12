using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] K = new int[] { 14, 12, 7, -4, 87, 0, 26, 17, 32, 55, 0, 77, 87, 24, 4 };
            for (int i = 0; i < K.Length; i++)
            {
                if (K[i] == 0)
                {
                    int a = i * i;
                    Console.WriteLine(a);
                }
               
            }

        }            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шведу_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[20] { 7, 10, 11, 13, 18, 22, 27, 46, 60, 62, 64, 65, 71, 73, 78, 82, 85, 87, 92, 93 };

            for (int i = 1; i < A.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    int a = A[i - 1];
                    Console.WriteLine(a);
                }
                if (i % 2 != 0)
                {
                    int a = A[i + 1];
                    Console.WriteLine(a);
                }
                else
                {
                    int a = A[i + 1];
                    Console.WriteLine(a);

                }
            }
        }
    }
}

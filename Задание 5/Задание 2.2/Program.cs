using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2._2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int sum = 0;
            int[] A = new int[] { 1, 9, 8, 5, 14 };        
            for (int i = 0; i <= A.Length - 1; i++)
            {
                if (i == A.Length - 1)
                {
                    int b = A[i] * A[i - 1];
                    sum = sum + b;
                    break;
                }
                if (i == 0)
                {
                    int b = A[i + 1] * A[i];
                    sum = sum + b;
                }              
                else
                {
                    int b = A[i] * A[i - 1] * A[i + 1];
                    sum = sum + b;
                    
                }
                

            }
            Console.WriteLine(sum);

        }
    }
}

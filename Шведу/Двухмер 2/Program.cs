using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двухмер_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задана квадратная матрица Q(5,5). Найти суммы элементов тех строк,
            //у которых элементы, расположенные на главной диагонали, равны нулю.
            int sum = 0;
            int[,] R = new int[,]
            {
                {5, 12, -8, 9, 7},
                {9, 11, 27, 14, 72 },
                {21, 15, 0, 80, 55},
                {3, 77, 89, 34, 25},
                {40, 30, 22, 31, 0}
            };
            int a = R.GetLength(0);
            for (int i = 0; i < R.GetLength(0); i++)
            {
                for (int j = 0; j < R.GetLength(1); j++)
                {                               
                        
                    
                }
                
            }
            Console.WriteLine(sum);
        }
       
    }
}

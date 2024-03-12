using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шведк_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int qq = 0; //счетчик
            int[] zxc = new int[30];
            Random rand = new Random();
            for (int i = 0; i < zxc.Length; i++)
            {
                zxc[i] = rand.Next(-15, 15);

            }
            for (int j = 0; j < zxc.Length; j++)
            {
                if (zxc[j] < 0)
                {
                    qq++;
                    Console.WriteLine("Отрицательный (-) элемент под индексом " + j);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Всего отрицательных элементов " + qq);
        }
    }
}
      


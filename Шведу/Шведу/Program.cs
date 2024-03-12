using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шведу
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ZXC = new int[] { 22, 44, 234, 534, -44, 234, -33, 228, -1337 };

            for (int i = 1; i < ZXC.Length; i++)
            {

                if (i % 2 == 0)
                {
                    int QQ = ZXC[i] * -1;
                    Console.WriteLine(QQ);
                }
            }
        }
    }
}

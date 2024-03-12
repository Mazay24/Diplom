using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шведу_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int[] zxc = new int[] { 3, 2, 5, 4, 17, 0, 13, 11};
            for (int i = 0; i <= zxc.Length - 1; i++)
            {
                if (i == zxc.Length - 1)
                {
                    int qq = zxc[i] * zxc[i - 1];
                    summa = summa + qq;
                    break;
                }
                if (i == 0)
                {
                    int qq = zxc[i + 1] * zxc[i];
                    summa = summa + qq;
                }
                else
                {
                    int qq = zxc[i] * zxc[i - 1] * zxc[i + 1];
                    summa = summa + qq;

                }


            }
            Console.WriteLine(summa);

        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шведу_5
{
    class Program
    {
        static void Main(string[] args)
        {
            


                int[] zxc = { 1, 123, 3, 4324, 115, 2, 4, 123, 8, 12, 135, 16, 29, 13, 242 };

                int qq1 = 5;

                int qq2 = 16;

                for (int i = 0; i < zxc.Length; i++)

                {

                    int hren = zxc[i];

                    if (hren > qq1)

                    {

                        if (hren < qq2)

                        {

                            Console.WriteLine(zxc[i]);

                        }

                    }

                }

                Console.ReadLine();
            
        }
    }
}

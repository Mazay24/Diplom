using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace гг2
{
    class My
    {
        public void Foo()
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double bb = 0;
            int gg = 1;           
            for (int z = 1 ; z < 10 ; z++)
            {
                gg *= z;
                if (z == 1)
                {
                    bb = 1 + ((2 * x) ^ z) / gg;
                }
                else
                {
                    bb = ((2 * x) ^ z) / gg;
                }
                bb += bb;
                Console.WriteLine(bb);


            }


        }
    }
}


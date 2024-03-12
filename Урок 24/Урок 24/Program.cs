using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Enumerable.Repeat(5, 10).ToArray();

            Console.WriteLine(myArray[0]);
        }
    }
}

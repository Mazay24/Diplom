using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_16
{
    class Program
    {
        static int Sum(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)//Выходит из рекурсии если в массиве нечего переберать!!!
                return 0;
    
            return myArray[i] + Sum(myArray, i + 1);

        }
        static void Main(string[] args)
        {
            int[] myArray = { 3, 14, 9 };

            int result = Sum(myArray);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_41
{
    class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;

        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            myArray ??= new int[0];//??= Сокращает код и в переменную пресваиваеться
                                    //Дефолтное значение.
            Console.WriteLine("Количество элементов в массиве: " + myArray.Length);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_13
{
    class Program
    {
        static void gg(ref int[] array, int value, int indx)
        {
            int[] newArray = new int[array.Length + 1]; //Создание нового массива где на 1 элемент больше!
            newArray[indx] = value;
            for (int i = 0; i < indx; i++) //Перебирает все элементы до нового индекса!
                newArray[i] = array[i];

            for (int i = indx; i < array.Length; i++) //Перебирает все элементы после нового индекса!

                newArray[i + 1] = array[i];

            array = newArray;
            
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 14, 55, 6, 9 };

            gg(ref myArray, -7, 3);
            Console.WriteLine(myArray[3]);
        }
    }
}

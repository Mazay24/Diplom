using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_14
{
    class Program
    {
        static void remuv(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];//Создание нового массива!
            for (int i = 0; i < index; i++)          
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)          
                newArray[i - 1] = array[i];
            
        }

        static void RemoveFirst(ref int[] array)
        {
            remuv(ref array, 0);
        }

        static void RemoveEnd(ref int[] array)
        {
            remuv(ref array, array.Length - 1);
        }


        static void Main(string[] args)
        {
            int[] myArray = { 5, 7, 21, 4, 68 };

            RemoveFirst(ref myArray); //Удаляет первый элемент массива!
             RemoveEnd(ref myArray); //Удаляет последний элемент массива!

        }
    }
}

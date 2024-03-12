using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_12_
{
    class Program
    {
        static void Resize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize]; //Создание нового массива!

            for (int i = 0; i < array.Length && i < newSize; i++) //Перебирает все элементы старого массива
            {
                newArray[i] = array[i]; //Присваевает все элементы старого массива в новый массив!
            }
            array = newArray; //В старый массив присвоиваются элементы нового массива!

            static void Main(string[] args)
            {
                int[] maArray = { 4, 14, 8 };

                Resize(ref maArray, 10); //Увеличение массива на 10 элементов!

            }
        }
    }
}

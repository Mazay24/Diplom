using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_15
{
    class Program
    {
        static void PrentArray(int[] myArray, int i = 0)
        {
            if (i < myArray.Length) //Если элемнты в массиве закончаться то вывод прикротиться!
            {
                Console.WriteLine(myArray[i]); //Выводит элемент массива!
                PrentArray(myArray, i + 1); //Обраещаемся к следующему элементу массива!
            }
            
        }
        static void Main(string[] args)
        {
            int[] myArray = { 5, 17, 14, 4 }; //Создал массив!

            PrentArray(myArray); //Оброщаемся к методу!
            
        }

    }
    
}

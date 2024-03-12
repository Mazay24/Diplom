using System;

namespace Урок_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 4, 5, 20, 80, 55, 1 };
            Console.WriteLine(myArray[^1]); /*Всегда выводит последее элемент
                                             * Индексация конца начинаеться с 1
                                             */

            int[] myArray2 = myArray[1..4]; //извлекаеться диапазон!
            

            Console.WriteLine(myArray[^2]); //Вывод 2 элемента с конца
            Index myIndex = ^2; 
            Console.WriteLine(myArray[myIndex]);//Также выводит 2 элемент с конца

            Range myRange = 1..4; // тоже самое что и
                                  // Range myRange = new Range(1,4);
            int[] myRange2 = myArray[myRange]; //делает тоже самое что и 14 строчка кода

            

        }
    }
}

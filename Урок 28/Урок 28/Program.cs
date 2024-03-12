using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[3, 5] //Изначально в каждой ячейке стоит 0!
            {
                  { 5, 10, 26, 47, 58}, //Вносим данные в ячейку
                  {13, 28, 4, 0, 77 }, 
                  {45,7, 9, 17, 66 }    
                                       
            };
            Console.WriteLine(myArray[1,2]); //Выводим данные из конкретной ячейки!

            int[,] myArray2 = new int[3, 5]; //Одна строчка занимает 13 и 14 строчки кода!
            myArray2[0, 2] = 55; //Вносим данные в ячейку массива!
            Console.WriteLine(myArray2[0,2]); //Извлекаем данные из ячейки!



        }
    }
}

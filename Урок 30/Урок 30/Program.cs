using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray = new int[,] //Изначально в каждой ячейке стоит 0!
           {
                  { 5, 10, 26, 47, 58}, //Вносим данные в ячейку
                  {13, 28, 4, 0, 77 },
                  {45,7, 9, 17, 66 }

            };
            Console.WriteLine(MyArray.Rank); //Показывает сколько измерений он содержит!
            Console.WriteLine(MyArray.Length); //Показывает сколько всего элементов в массиве!
            Console.WriteLine(MyArray.GetLength(0));//Показывает сколько элементов в первом измерении!
            Console.WriteLine(MyArray.GetLength(1));//Показывает сколько элементов в втором измерении!
                                                
            int height = MyArray.GetLength(0);
            int width = MyArray.GetLength(1);

            for (int y = 0; y < height; y++) //Переперает столбци
            {
                for (int x = 0; x < width; x++) //Переперает строки
                {
                    Console.Write(MyArray[y, x] + "\t" );
                }
                Console.WriteLine();
            }

        }
    }
}

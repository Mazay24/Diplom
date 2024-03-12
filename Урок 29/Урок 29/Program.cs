using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MyArray = new int[3, 5] //Изначально в каждой ячейке стоит 0!
           {
                  { 5, 10, 26, 47, 58}, //Вносим данные в ячейку
                  {13, 28, 4, 0, 77 },
                  {45,7, 9, 17, 66 }

            };
            foreach (var item in MyArray) //foreach извелкет элементы в переменую item!
            {
                Console.Write(item + " ");
            }

        }
    }
}

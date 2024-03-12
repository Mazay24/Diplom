using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][]; /* Создание зубчатого массива но пока,
                                             * что это просто одномерный массив
                                             * так как мы не выделели память для каждой
                                             * страки
                                             */

            myArray[0] = new int[3];
            myArray[1] = new int[2];
            myArray[2] = new int[5];

            /*
             * myArray[0][2] = 14; Зполнем элемент массива
             *Console.WriteLine(myArray[0][2]); Выводим этот элемент в консоль!
             */

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(250); //Генерирует рандомные числа!
                }

            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();



            }
        }
    }
}

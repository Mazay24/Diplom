﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t"); /* Просим вести сколько элементов
                                                                       * в массиве мы хотим иметь!
                                                                       * 
                                                                       */
            int element = int.Parse(Console.ReadLine());//Вводимэто значение!
            int[] myArray = new int[element];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: \t");
                myArray[i] = int.Parse(Console.ReadLine());/*Вводим с клавиатуры элементы
                                                            * массива!
                                                            */

            }
            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];

                }
            }
            Console.WriteLine("Сумма чётных чисел: " + result);
        }
    }
}

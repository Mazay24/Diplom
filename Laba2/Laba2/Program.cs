using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenght];
            Random rand = new Random();
            Console.Write("Первоначальный массив: ");
            for (int i = 0; i < lenght; i++)
            {
                array[i] = rand.Next(-1, 14);
                Console.Write(array[i] + " , ");
            }


            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > k)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = k;
            }

            Console.WriteLine();
            Console.Write("Полученный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " , ");
            }


        }
    }
}
        
    


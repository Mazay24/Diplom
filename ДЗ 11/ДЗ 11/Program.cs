using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_11
{
    class Program
    {
        static int IndexOf(int [] array, int value) //Создает метод!
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == value) 
                {
                    return i;
                }
            {

            }
            return -1;//Выводится если не нашёл идекса с таким числом!!!
        }

        static int[] RandomArray(uint length, int min, int max)
        {
            int[] myArray = new int[length];
            Random random = new Random(); //Рандомно заполняет массив

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(min, max);
            }

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = RandomArray(10, -5, 10);

            int result = IndexOf(myArray, 4); // Вызывает метод!

            Console.WriteLine(result);

        }
    }
}

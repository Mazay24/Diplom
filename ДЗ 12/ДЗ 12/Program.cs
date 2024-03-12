using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maArray = { 4, 14, 8 }; //создаем массив на 3 элемента 

            Array.Resize(ref maArray, 10); //Увеличиваем массив на 10 элементов
                                           //При этом первые 3 элемента сохраняться!

            Array.Resize(ref maArray, 2); //При уменьшении массива остануться только 2 элемента:4 и 14!

        }
    }
}

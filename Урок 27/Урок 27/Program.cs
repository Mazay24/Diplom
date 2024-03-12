using System;

namespace Урок_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!!! =)";
            Console.WriteLine(str[0..5]); // Указываем диапозон элементов и они выводяться в консоль
            Console.WriteLine(str[6..11]);  
        }
    }
}

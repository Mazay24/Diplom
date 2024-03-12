using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_52
{
    class Point //Создаём класс!!!
    {
        public int x;//Поле класса!!!

        public int y;//Поле класса!!!
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();//Cоздаеи экземляр!!!
            p.x = 4;
            p.y = 2;
            Console.WriteLine(p.x);// Console.WriteLine($"X: {p.x} | Y: {p.y}");                              
            Console.WriteLine(p.y);

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 6;

            Console.WriteLine($"X: {p2.x} | Y: {p2.y}");

        }
    }
}

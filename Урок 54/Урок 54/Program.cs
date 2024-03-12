using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_54
{
    class Point
    {
        int z = 3; //По умолчанию считается как private!!!
        public int x = 55;
        private int y = 14;

        private void PrintX()
        {
            Console.WriteLine($"X: {x}");
        }
        public void PrintY()
        {
            Console.WriteLine($"Y: {y}");
        }
        public void Print()
        {
            PrintX();
            PrintY();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
            point.PrintY();
        }
    }
}

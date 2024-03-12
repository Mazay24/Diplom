using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_57
{
    class Point
    {
        public Point()
        {
            _x = _y = 1;
        }
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"X: {_x}\tY: {_y}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Print();
        }
    }
}

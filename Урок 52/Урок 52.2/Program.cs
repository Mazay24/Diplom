using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_52._2
{
    enum Color
    {
        Red,
        Blue,
        Orange,
        Green,
        Yellow
    }
    class Point 
    {
        public int x;
        public int y;

        public Color color;
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.y = 2;
            p.x = 4;
            p.color = Color.Blue;
            Console.WriteLine($"X: {p.x} | Y: {p.y}");
            Console.WriteLine(p.color);
        }
    }
}

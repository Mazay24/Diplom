using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_59
{
    class Point
    {
        private int x;
        
        public void SetX(int x)
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }
        }
        public int GetX()
        {
            return x;
        }
        private int y;

        public int Y //propfull
        {
            get 
            { 
                return y;
            }
            set 
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 5)
                {
                    y = 5;
                    return;
                }
                y = value;
            }
        }
        public int Z { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Y = 14;
            int y = point.Y;
            Console.WriteLine(y);
        }
    }
}

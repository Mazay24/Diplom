using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_68
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Вызван конструктор класса MyСlass!");
        }
    }
    class Class2D : MyClass
    {
        public Class2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Вызван конструктор класса Class2D!");
        }
        public int X { get; set; }
        public int Y { get; set; }
        public void Print2D()
        {
            Console.WriteLine("X:\t" + X);
            Console.WriteLine("Y:\t" + Y);
        }
    }
    class Class3D : Class2D
    {
        public Class3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Вызван конструктор класса Class3D!");
        }
        public int Z { get; set; }
        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine("Z:\t" + Z);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Class3D clas = new Class3D(14, 55, 7);
                clas.Print3D();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_78
{
    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    public struct SructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    class Program
    {
        static void Foo(ClassPoint classpoint)
        {
            classpoint.X++;
            classpoint.Y++;
        }
        static void Bar(SructPoint sructPoint)
        {
            sructPoint.X++;
            sructPoint.Y++;
        }
        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();
            SructPoint sructPoint = new SructPoint();

            Foo(classPoint);
            Bar(sructPoint);
        }
    }
}

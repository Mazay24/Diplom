using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_51._3
{
    class Program
    {
        enum Color
        {
            Blue,
            Orange,
            Red,
            Green,
            While

        }
        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(Color));

            foreach (var item in values)
            {
                Console.WriteLine(item);//Выводит весь список enum Color!!!
            }
        }
    }
}

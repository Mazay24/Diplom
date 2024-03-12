using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fanSpeed = 3000;
            bool isHighTemperature = true;
            bool hasNoCooling = fanSpeed<=0;

            if (isHighTemperature || hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процуссора!!!");

            }
        }
    }
}

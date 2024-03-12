using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_47
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.2;
            float b = (float)a;//Не явное преобразование!!!

            int c = 5;
            float d = c;//Явное преобразование!!!

            int qwik = 14;
            bool hc = Convert.ToBoolean(qwik);

            int mir = 7;
            float tir = 3.14f;//f показывает что это тип данных float!!!
            int resilt = mir + (int)tir;//При сложении потеряется дробная часть!!! 

        }
    }
}

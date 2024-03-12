using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_64
{
    
    partial class Class1
    {
        public string Go()
        {
            return FirstName + " " + LastName;
        }
        public void Print()
        {
            Console.WriteLine(Go());
        }
    }
}

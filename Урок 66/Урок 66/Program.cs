using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_66
{
    class Program
    {
        static void Main(string[] args)
        {

            персонал pers = new персонал
            {
                FirstName = "Top",
                LastName = "Gap",
                address = new Adrress
                {
                    Country = "RUS",
                    Reg = "PEN",
                    City = "PEN"
                }

            };
            
        }
    }
}

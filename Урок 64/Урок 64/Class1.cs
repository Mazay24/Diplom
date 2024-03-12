using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_64
{
   partial class Class1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Class1(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        
    }
}

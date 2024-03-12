using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_67
{
    class Persanal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"Меня зовут {FirstName}!");
        }
    }
    class Student: Persanal
    {
        public void See()
        {
            Console.WriteLine("Я учусь!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student { FirstName = "Никита", LastName = "Не твой" };
            stud.Print();
            stud.See();
            Persanal pers = new Student { FirstName = "Никита", LastName = "Не твой" };
            pers.Print();
        }
    }
}

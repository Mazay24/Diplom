using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_53
{
    
    
        class Program
        {
            static Student GetStudent()
            {
                Student student = new Student();

                student.firstname = "Карина";
                student.lastname = "Жидкова";
                student.middname = "Олеговна";
                student.age = 22; //Тёть Карина.
                student.id = Guid.NewGuid();
                student.group = "Котиков";

                return student;
            }
         
            static void Main(string[] args)
            {
                var firstStudent = GetStudent();

                firstStudent.Print();

            Console.WriteLine();
            Console.WriteLine();

                 var second = new Student();
            second.Print();

            string FullName = firstStudent.GetFullName();
            Console.WriteLine();
            Console.WriteLine(FullName);


            }
        }
    
}


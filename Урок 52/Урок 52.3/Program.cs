using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_52._3
{
    class Student
    {
        public Guid id;
        public string firstname;
        public string lastname;
        public string middname;
        public int age;
        public string group;
    }
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

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте: ");
            Console.WriteLine($"Id: { student.id}");
            Console.WriteLine($"Фамилия: {student.lastname}");
            Console.WriteLine($"Имя: { student.firstname}");
            Console.WriteLine($"Отчество: { student.middname}");
            Console.WriteLine($"Возраст: { student.age}");
            Console.WriteLine($"Группа: { student.group}");
        }
       
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();

            Print(firstStudent);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_58
{
    class Student
    {
        public Student(string lastName, DateTime birtday)
        {
            this.lastName = lastName;
            this.birtday = birtday;
        }
        public Student(string lastName,string firstName, string middleName, DateTime birtday):this(lastName, birtday)
        {           
            this.firstName = firstName;
            this.middleName = middleName;         
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        private string lastName;
        private string firstName;
        private string middleName;
        private DateTime birtday;
        public void Print()
        {
            Console.WriteLine($"Имя: {firstName}\nФамилия {lastName}\nОтчество: {middleName}\nДата рождения: {birtday}");
        }
        

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Эчпочмак", "Эчмокмаков", "Эчпочмакович", new DateTime(2004, 12, 31));
            student1.Print();
            Console.WriteLine();
            Student student2 = new Student("Вареников", new DateTime(996, 5, 5));
            student2.Print();
        }
    }
}

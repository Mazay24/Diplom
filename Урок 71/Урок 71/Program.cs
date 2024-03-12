using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_71
{
    class Car
    {
        protected void Start()
        {
            Console.WriteLine("Двигатель запущен!");
        }
        public virtual void Drive()
        {
            Start();
            Console.WriteLine("Я машина, я еду!");
        }
    }
    class SportCar : Car
    {
        public override void Drive()
        {
            Start();
            Console.WriteLine("Я машина, 1000HP еду нереально быстро!");
        }
    }
    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new SportCar());
        }
    }
}

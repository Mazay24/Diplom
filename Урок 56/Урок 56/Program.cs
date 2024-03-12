using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_56
{
    class Gun
        //Конструктор - специальный метод который используется для создания объекта!!!
    {
        //Вводим ctor!!!
        public Gun()//генерируется конструктор!!!
        {
            isLoaded = true;//Не нарушая инкапсуляции, изменяем состояние объекта!!!
        }


        private bool isLoaded;

        private void Relode()
        {
            Console.WriteLine("Заряжаю...");
            isLoaded = true;
            Console.WriteLine("Заряжено");
        }
        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Relode();
            }
            Console.WriteLine("Пиу - Пиу\n");
            isLoaded = false;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();
            gun.Shoot();
        }
    }
}

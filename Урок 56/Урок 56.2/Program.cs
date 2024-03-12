using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_56._2
{
    class Gun   
    {       
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }

        private bool _isLoaded;

        private void Relode()
        {
            Console.WriteLine("Заряжаю...");
            _isLoaded = true;
            Console.WriteLine("Заряжено");
        }
        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Relode();
            }
            Console.WriteLine("Пиу - Пиу\n");
            _isLoaded = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
                Gun gun = new Gun(isLoaded: false);
                gun.Shoot();
                gun.Shoot();
            
        }
    }
}

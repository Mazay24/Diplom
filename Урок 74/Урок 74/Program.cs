using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_74
{
    interface IWeapon
    {
        void Fire();
    }
    interface IRezny : IWeapon
    {
        void Throm();
    }
    class Gun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пиу!");
        }
    }
    class Luk : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Тунь!");
        }
    }
    class Pushka : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Бабах!");
        }
    }
    class Laser : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Дзззз!");
        }
    }
    class Knife : IRezny
    {
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Щааа!");
        }

        public void Throm()
        {
            Console.WriteLine($"{GetType().Name}: Хрясть!");
        }
    }
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
        public void Throw(IRezny rezny)
        {
            rezny.Throm();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IWeapon[] invent = { new Gun(), new Luk(), new Pushka(), new Laser() };

            foreach (var item in invent)
            {

                player.Fire(item);
                Console.WriteLine();
            }
            player.Throw(new Knife());
        }   
    }
}
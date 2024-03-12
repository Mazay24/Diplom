using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_72
{
    abstract class Weapon
    {
        public abstract int Damag { get; }
        public abstract void Fire();//Абстрактные методы можно создать только в абстрактных методах!

        public void Show()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damag}");
        }
    }
    class Gun : Weapon
    {
        public override int Damag { get { return 15; } }

        public override void Fire()
        {
            Console.WriteLine("Пиу");
        }
    }
    class Luk : Weapon
    {
        public override int Damag => 3;

        public override void Fire()
        {
            Console.WriteLine("Тюнь");
        }
    }
    class Pushka : Weapon
    {
        public override int Damag => 55;

        public override void Fire()
        {
            Console.WriteLine("Скертыщ");
        }
    }
    class Laser : Weapon
    {
        public override int Damag => 100;

        public override void Fire()
        {
            Console.WriteLine("Дзззззз");
        }
    }
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }
        public void Info(Weapon weapon)
        {
            weapon.Show();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] invent = { new Gun(), new Luk(), new Pushka(), new Laser() };

            foreach (var item in invent)
            {
                player.Info(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }
}

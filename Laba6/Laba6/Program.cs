using System;

namespace Laba6
{

    class Animal
    {
        public string NameAnimal;
        public string food;
        public string location;
        

        public Animal(string location, string NameAnimal, string food)
        {
            this.NameAnimal = NameAnimal;
            this.food = food;
            this.location = location;
        }
        public virtual void eat()
        {
            Console.WriteLine("*чавкает* \n ест ");
        }
        public virtual void makeNoise()
        {
            Console.WriteLine(NameAnimal + "мяукает");
        }
        public void sleep()
        {

            Console.WriteLine("спит");
        }
    }
    class Dog : Animal
    {
        public string NameAnimal;

        public Dog(string location, string NameAnimal, string food) : base(location, NameAnimal, food){

        }
        public override void eat()
        {
            Console.WriteLine(NameAnimal + "ест: " + food);
        }
        public override void makeNoise()
        {
            Console.WriteLine(NameAnimal + "лает");
        }

        public void sleep()
        {
            Console.WriteLine(NameAnimal + "спит");
        }
    }

    class Cat : Animal
    {
        public string NameAnimal;

        public Cat(string location, string NameAnimal, string food) : base(location, NameAnimal, food)
        {
        }
        public override void eat()
        {
            Console.WriteLine(NameAnimal + "ест: " + food);
        }
        public override void makeNoise()
        {
            Console.WriteLine(NameAnimal + "мяукает");
        }

        public void sleep()
        {
            Console.WriteLine(NameAnimal + "спит");
        }
    }

    class Hourse : Animal
    {
        public string NameAnimal;

        public Hourse(string location, string NameAnimal, string food) : base(location, NameAnimal, food)
        {
        }
        public override void eat()
        {
            Console.WriteLine(NameAnimal + "ест: " + food);
        }
        public override void makeNoise()
        {
            Console.WriteLine(NameAnimal + "делает брууу");
        }

        public void sleep()
        {
            Console.WriteLine(NameAnimal + "спит");
        }
    }

    class Veterenar
    {

        public void treatAnimal(Animal animal)
        {
            Console.WriteLine("Место жительства: " + animal.location);
            Console.WriteLine("еда: " + animal.food);
            Console.WriteLine(animal.NameAnimal + " на приеме у Ветеринара\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Veterenar veterenar = new Veterenar();

            Dog dog = new Dog("Москва", "Бобик", "мясо");
            Cat cat = new Cat("Пенза", "Снежок", "стейк");
            Hourse hourse = new Hourse("Село Курчаева", "звездочка", "морковь");

            veterenar.treatAnimal(dog);
            veterenar.treatAnimal(cat);
            veterenar.treatAnimal(hourse);

            
        }
    }
}


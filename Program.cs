using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            Dog dog = new Dog("Собака");
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
        abstract class Animal
        {
            public string Name { get; set; }
            public Animal(string name )
            {
                if (name == null)
                {
                    Name = "Ворона";
                }
                else
                {
                    Name = name;
                }
            }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }
        }
        class Dog : Animal
        {
            public string song { get; set; }
            public Dog(string name)
            : base(name)
            {
                song = "Гав";
            }
            public override void Say()
            {
                Console.WriteLine($"{song}");
            }
        }
        class Cat : Animal
        {
            public string song { get; set; }
            public Cat(string name)
            : base(name)
            {
                song = "Мяу";
            }
            public override void Say()
            {
                Console.WriteLine($"{song}");
            }
        }

    }
}

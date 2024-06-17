
using System;
namespace hierarchicalInheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing");
        }
    }

    public class StartUp
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}

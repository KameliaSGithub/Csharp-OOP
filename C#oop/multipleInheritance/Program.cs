using System;

namespace multipleInheritance
{
    public interface IAnimal
    {
        void Eat();
    }

    public class Animal : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public interface IDog
    {
        void Bark();
    }

    public class Dog : IDog
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    public class Puppy : IAnimal, IDog
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }

        public void Bark()
        {
            Console.WriteLine("barking...");
        }

        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }

    public class StartUp
    {
        public static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}


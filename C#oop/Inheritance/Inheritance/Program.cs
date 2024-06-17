namespace Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    public class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }
    }
}

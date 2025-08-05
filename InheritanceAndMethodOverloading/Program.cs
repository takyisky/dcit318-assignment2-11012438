using System;

namespace InheritanceAndMethodOverloading
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Dog class inherits from Animal
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Cat class to also inherit from animal and overide
    class Cat : Animal
    {
        public override void MakeSound()
        {

            Console.WriteLine("Meow");
        }

    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the animal class 
            Animal genericAnimal = new Animal();
            genericAnimal.MakeSound();

            //Testing the dog class
            Dog dog = new Dog();
            dog.MakeSound();

            //Testing the cat class
            Cat cat = new Cat();
            cat.MakeSound();
        }
    }
}

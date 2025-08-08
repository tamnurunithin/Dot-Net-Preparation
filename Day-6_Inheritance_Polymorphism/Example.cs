using System;

namespace Day06Examples
{
    // Base class with a virtual method
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Derived class that overrides and seals the method
    class Dog : Animal
    {
        public sealed override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Further derived class attempting to override sealed method
    // This will cause a compile-time error if uncommented
    /*
    class Puppy : Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine("Puppy yaps.");
        }
    }
    */

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.MakeSound(); // Output: Animal makes a sound.

            Dog myDog = new Dog();
            myDog.MakeSound();    // Output: Dog barks.

            // Uncommenting below will cause error because MakeSound is sealed
            // Puppy myPuppy = new Puppy();
            // myPuppy.MakeSound();
        }
    }
}

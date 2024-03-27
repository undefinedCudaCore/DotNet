using _013_Interfaces_Exercises.Contracts;
using _013_Interfaces_Exercises.Base;

namespace _013_Interfaces_Exercises.Animals
{
    internal class Carp : Animal, IAnimal, IFish
    {
        public Carp(int age, string name, string color) : base(age, name, color)
        {
            Age = age;
            Name = name;
            Color = color;
        }

        public void Breeth()
        {
            Console.WriteLine("I can breath under water.");
        }

        public void DropEggs()
        {
            Console.WriteLine("No, I'm male.");
        }

        public void Eat()
        {
            Console.WriteLine("Eating algae.");
        }

        public void Move()
        {
            Console.WriteLine("Going for a swim.");
        }

        public void Play()
        {
            Console.WriteLine("Playing with my fish friends.");
        }

        public void Sleep()
        {
            Console.WriteLine("Do fish sleep?");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swiming too slow.");
        }
    }
}

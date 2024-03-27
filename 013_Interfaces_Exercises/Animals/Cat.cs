using _013_Interfaces_Exercises.Contracts;
using _013_Interfaces_Exercises.Base;

namespace _013_Interfaces_Exercises.Animals
{
    internal class Cat : Animal, IAnimal, IMammal
    {
        public Cat(int age, string name, string color) : base(age, name, color)
        {
            Age = age;
            Name = name;
            Color = color;
        }

        public void Eat()
        {
            Console.WriteLine("Eating cat food.");
        }

        public void EatMilkFromBreast()
        {
            Console.WriteLine("I'm not, but I'm breasting my child.");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Yes, I have child.");
        }

        public void Move()
        {
            Console.WriteLine("Going for a walk with my little one.");
        }

        public void GrowFur()
        {
            Console.WriteLine("Growed short fur.");
        }

        public void Play()
        {
            Console.WriteLine("Playing with a ball with my little one");
        }

        public void Sleep()
        {
            Console.WriteLine("Going to sleep at 13:00, 18:00, 20:00.");
        }

    }
}

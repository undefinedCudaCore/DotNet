using _013_Interfaces_Exercises.Base;
using _013_Interfaces_Exercises.Contracts;

namespace _013_Interfaces_Exercises.Animals
{
    public class Dog : Animal, IAnimal, IMammal, IComparable<Dog>
    {
        public Dog(int age, string name, string color) : base(age, name, color)
        {
            Age = age;
            Name = name;
            Color = color;
        }

        public void Eat()
        {
            Console.WriteLine("Eating dog food.");
        }

        public void EatMilkFromBreast()
        {
            Console.WriteLine("I'm too old for this.");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Cannot, I'm male.");
        }

        public void Move()
        {
            Console.WriteLine("Going for a walk with my owner.");
        }

        public void GrowFur()
        {
            Console.WriteLine("Growed long fur.");
        }

        public void Play()
        {
            Console.WriteLine("Playing with a ball my owner throw to me.");
        }

        public void Sleep()
        {
            Console.WriteLine("Going to sleep at 20:00.");
        }

        public int CompareTo(Dog other)
        {
            return String.Compare(Color, other.Color);
            //return this.Color.CompareTo(other.Color);
        }
    }
}

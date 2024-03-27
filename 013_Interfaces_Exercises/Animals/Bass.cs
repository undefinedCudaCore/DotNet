using _013_Interfaces_Exercises.Contracts;
using _013_Interfaces_Exercises.Base;

namespace _013_Interfaces_Exercises.Animals
{
    internal class Bass : Animal, IAnimal, IFish
    {
        public Bass(int age, string name, string color) : base(age, name, color)
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
            Console.WriteLine("Yes I am.");
        }

        public void Eat()
        {
            Console.WriteLine("Eating seagrass.");
        }

        public void Move()
        {
            Console.WriteLine("Going for a double swim.");
        }

        public void Play()
        {
            Console.WriteLine("Playing with my fish kids.");
        }

        public void Sleep()
        {
            Console.WriteLine("Do fish sleep?");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swiming too fast.");
        }
    }
}

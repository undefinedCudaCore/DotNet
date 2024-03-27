using _013_Interfaces_Exercises.Animals;
using _013_Interfaces_Exercises.Contracts;

namespace _013_Interfaces_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> iAnimal = new List<IAnimal>()
            {
                new Dog(2, "Spike", "Grey"),
                new Cat(3, "Daisy", "Brown"),
                new Carp(1, "Carry", "Black/Grey"),
                new Bass(2, "Bassy", "Grey/Black"),
            };

            List<IMammal> iMammal = new List<IMammal>()
            {
                new Dog(1, "Lord", "Yellow"),
                new Cat(5, "Daisy", "Blue"),
                new Dog(7, "Arc", "White"),
                new Cat(8, "Kai", "Red"),
            };

            List<IFish> iFish = new List<IFish>()
            {
                new Carp(10, "Jim", "Red"),
                new Bass(12, "Carrey", "Green"),
                new Carp(1, "Lesley", "Blue"),
                new Bass(9, "Nillson", "Black"),
            };

            //ForEachIAnimal(iAnimal);
            //ForEachIMammal(iMammal);
            //ForEachIFish(iFish);

            List<Dog> dogs = new List<Dog>()
            {
                new Dog(2, "Spike", "Grey"),
                new Dog(1, "Lord", "Yellow"),
                new Dog(7, "Arc", "White"),
            };

            dogs.Sort();
        }

        private static void ForEachIFish(List<IFish> iFish)
        {
            foreach (var fish in iFish)
            {
                fish.Breeth();
                fish.DropEggs();
                fish.Swim();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void ForEachIMammal(List<IMammal> iMammal)
        {
            foreach (var mammal in iMammal)
            {
                mammal.GrowFur();
                mammal.GiveBirth();
                mammal.EatMilkFromBreast();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void ForEachIAnimal(List<IAnimal> iAnimal)
        {
            foreach (var animal in iAnimal)
            {
                animal.Eat();
                animal.Sleep();
                animal.Move();
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

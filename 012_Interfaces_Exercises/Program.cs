using _012_Interfaces_Exercises.Cars;
using _012_Interfaces_Exercises.Comparers;

namespace _012_Interfaces_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BmwCar bmdThreeTwoOu = new BmwCar(false, "BMW 320", 31);
            AudiCar audiQSeven = new AudiCar(true, "Audi Q7", 19);

            Console.WriteLine(bmdThreeTwoOu.Drive());
            Console.WriteLine(audiQSeven.Drive());

            if (!bmdThreeTwoOu.Drive())
            {
                bmdThreeTwoOu.Refuel(100);
            }
            if (!audiQSeven.Drive())
            {
                audiQSeven.Refuel(100);
            }

            Console.WriteLine(audiQSeven.Drive());
            Console.WriteLine(bmdThreeTwoOu.Model);
            Console.WriteLine(audiQSeven.Model);

            List<BmwCar> bmwCars = new List<BmwCar>
            {
                new BmwCar(false, "model005", 20),
                new BmwCar(true, "model003", 120),
                new BmwCar(true, "model010", 250),
            };

            List<AudiCar> audiCars = new List<AudiCar>
            {
                new AudiCar(false, "Q7", 20),
                new AudiCar(true, "Q3", 120),
                new AudiCar(true, "Q1", 250),
                new AudiCar(true, "Q5", 25),
            };

            var bmwCarComparer = new BmwCarComparer();
            var audiCarComparer = new AudiCarComparer();

            bmwCars.Sort(bmwCarComparer);
            audiCars.Sort(audiCarComparer);
        }
    }
}

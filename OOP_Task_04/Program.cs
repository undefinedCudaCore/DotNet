using OOP_Task_04.Cars;

namespace OOP_Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "Dodge";
            car1.Model = "Journey";


            Wheels continentalR16 = new Wheels("Continental", 16, 55, 205);

            for (int i = 0; i < 4; i++)
            {
                car1.Wheels.Add(continentalR16);
            }

            Car.RunEngine(car1);

            ShowIsCarEngineOn(car1);
        }

        public static void ShowIsCarEngineOn(Car car)
        {
            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine("Engine is " + car.Engine.EngineIsOn);
        }
    }
}

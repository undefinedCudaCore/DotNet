using _012_Interfaces_Exercises.Contracts;

namespace _012_Interfaces_Exercises
{

    public abstract class Car : IVehicle
    {
        protected Car(string model, int fuel)
        {
            Model = model;
            Fuel = fuel;
        }

        public string Model { get; set; }
        public int Fuel { get; set; }

        public bool Drive()
        {
            Fuel -= 10;

            if (Fuel >= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Refuel(int refillFuelTank)
        {
            if (refillFuelTank < 0)
            {
                Fuel += refillFuelTank;
                return false;
            }
            if (refillFuelTank >= 0)
            {
                Fuel += refillFuelTank;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

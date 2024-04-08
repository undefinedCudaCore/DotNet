namespace _012_Interfaces_Exercises.Cars
{
    internal class BmwCar : Car
    {
        public bool IsXDrive { get; set; }

        public BmwCar(bool isXDrive, string model, int fuel) : base(model, fuel)
        {
            IsXDrive = isXDrive;
            Model = model;
            Fuel = fuel;
        }
    }
}

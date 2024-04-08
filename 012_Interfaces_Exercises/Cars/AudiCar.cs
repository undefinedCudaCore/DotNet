namespace _012_Interfaces_Exercises.Cars
{
    internal class AudiCar : Car
    {
        public bool IsQuattro { get; set; }
        public AudiCar(bool isXDrive, string model, int fuel) : base(model, fuel)
        {
            IsQuattro = isXDrive;
            Model = model;
            Fuel = fuel;
        }
    }
}

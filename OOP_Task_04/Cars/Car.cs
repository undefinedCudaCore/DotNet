namespace OOP_Task_04.Cars
{
    internal class Car
    {
        public Car()
        {
            DateOfManufacture = DateTime.Now;
            Wheels = new List<Wheels>();
            Engine = new Engine();
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public Engine Engine { get; set; }
        public List<Wheels> Wheels { get; set; }

        public static string RunEngine(Car car)
        {
            return car.Engine.EngineIsOn = "ON";
        }
    }
}

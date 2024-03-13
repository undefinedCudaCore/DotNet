namespace _2_1_3_IheritanceVirtualMethods.Vehicle
{
    internal class Car : Vehicle
    {

        public Car(string make, string model, int id, int speed) : base(id, speed)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }
    }
}

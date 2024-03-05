namespace _2_1_3_IheritanceVirtualMethods.Vehicle
{
    internal class Vehicle
    {
        public Vehicle(int id, int speed)
        {
            Id = id;
            Speed = speed;
        }

        public int Id { get; set; }
        public int Speed { get; set; }
    }
}

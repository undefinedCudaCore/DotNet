namespace OOP_Task_04.Cars
{
    internal class Wheels
    {
        public Wheels(string manufacture, int radius, int height, int width)
        {
            Manufacture = manufacture;
            Radius = radius;
            Height = height;
            Width = width;
        }

        public string Manufacture { get; set; }
        public int Radius { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}

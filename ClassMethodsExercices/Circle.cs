namespace ClassMethodsExercices
{
    internal class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double Area()
        {
            return double.Pi * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return 2 * double.Pi * Radius;
        }
    }
}

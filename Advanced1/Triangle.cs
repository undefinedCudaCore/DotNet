namespace Advanced1
{
    internal class Triangle
    {
        public Triangle(double a, double b, double basis)
        {
            BorderAB = a;
            BorderBC = b;
            Basis = basis;
        }

        public double BorderAB { get; set; }
        public double BorderBC { get; set; }
        public double Basis { get; set; }
    }
}

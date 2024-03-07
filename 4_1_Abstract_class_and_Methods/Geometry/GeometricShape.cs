namespace _4_1_Abstract_class_and_Methods.Geometry
{
    internal abstract class GeometricShape
    {
        protected GeometricShape(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}

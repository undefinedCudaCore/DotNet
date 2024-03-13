namespace _4_1_Abstract_class_and_Methods.Geometry
{
    internal class Triangle : GeometricShape
    {
        /// <summary>
        /// Simple set for triangel borders and height
        /// </summary>
        /// <param name="sideA">One side of triangle</param>
        /// <param name="sideB">Second side of triangle</param>
        /// <param name="sideC">Basis of triangle/param>
        /// <param name="sideD">Height of triangle</param>
        public Triangle(double sideA, double sideB, double sideC, double sideD) : base(sideA, sideB, sideC, sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }

        public override double GetArea()
        {
            return 0.5 * SideB * SideC;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}

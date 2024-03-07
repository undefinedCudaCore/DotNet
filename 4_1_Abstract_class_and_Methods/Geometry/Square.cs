namespace _4_1_Abstract_class_and_Methods.Geometry
{
    internal class Square : GeometricShape
    {
        /// <summary>
        /// Simple set for square borders
        /// </summary>
        /// <param name="sideA">All borders are the same</param>
        /// <param name="sideB">All borders are the same</param>
        /// <param name="sideC">All borders are the same</param>
        /// <param name="sideD">All borders are the same</param>
        public Square(double sideA, double sideB, double sideC, double sideD) : base(sideA, sideB, sideC, sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
        }
        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
    }
}

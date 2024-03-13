namespace _3_2_Virtual_Methods.Shapie
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("A rectangle is a closed 2-D shape, having 4 sides, 4 corners, and 4 right angles (90°).");
            Console.WriteLine();
        }
    }
}

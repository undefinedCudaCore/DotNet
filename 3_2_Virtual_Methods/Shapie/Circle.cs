namespace _3_2_Virtual_Methods.Shapie
{
    internal class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle");
            Console.WriteLine("A circle is a shape consisting of all points in a plane " +
                "that are at a given distance from a given point, the centre.");
            Console.WriteLine();
        }
    }
}

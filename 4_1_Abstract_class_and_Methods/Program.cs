using _4_1_Abstract_class_and_Methods.Geometry;

namespace _4_1_Abstract_class_and_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1.1.-------------------------------------------
            Square square = new Square(5, 5, 5, 5);
            Square square2 = new Square(2, 2, 2, 2);
            Square square3 = new Square(15, 15, 15, 15);
            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(square.GetPerimeter());

            Triangle triangle = new Triangle(2, 2, 4, 3);
            Triangle triangle2 = new Triangle(5, 5, 8, 4);
            Triangle triangle3 = new Triangle(10, 10, 15, 7);
            //Console.WriteLine(triangle.GetArea());
            //Console.WriteLine(triangle.GetPerimeter());

            List<GeometricShape> shapes = new List<GeometricShape>();
            shapes.Add(square);
            shapes.Add(triangle);
            shapes.Add(square2);
            shapes.Add(triangle2);
            shapes.Add(square3);
            shapes.Add(triangle3);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
                Console.WriteLine(shape.GetPerimeter());
            }
        }
    }
}

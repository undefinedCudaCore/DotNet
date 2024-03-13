using _3_2_Virtual_Methods.MyEmployee;
using _3_2_Virtual_Methods.Shapie;

namespace _3_2_Virtual_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1.1. / 1.2.----------------------------
            Employee ted = new Employee("Ted", 1500);

            //ted.Greeting();

            Manager tom = new Manager("Tom", 2500);

            //tom.Greeting();

            //Exercise 1.3.----------------------------
            Shape shape = new Shape();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            shape.Draw();
            rectangle.Draw();
            circle.Draw();
        }
    }
}

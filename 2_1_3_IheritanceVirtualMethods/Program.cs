using _2_1_3_IheritanceVirtualMethods.Employee;
using _2_1_3_IheritanceVirtualMethods.Product;
using _2_1_3_IheritanceVirtualMethods.Vehicle;

namespace _2_1_3_IheritanceVirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1.1.------------------
            Car car = new Car("VW", "Golf", 1, 50);

            //Console.WriteLine(car.Speed);

            Bike bike = new Bike(2, 5);

            // Exercise 1.2.------------------
            Manager manager = new Manager("Don", 15000);

            //Console.WriteLine(manager.Name);
            //Console.WriteLine(manager.Salary);
            //Console.WriteLine(manager.Employees);

            // Exercise 1.3.------------------
            Manager steve = new Manager("Steve", 1200);

            steve.AddProgrammer(new Programmer("C#", "Tadas", 900));
            steve.AddProgrammer(new Programmer("Java", "Tomas", 1900));
            steve.AddProgrammer(new Programmer("Html", "Alfas", -5000));

            steve.PrintProgrammersInformationOfOneManager();

            // Exercise 1.4.------------------
            Food pie = new Food(5);
            pie.Name = "Cranberry pie";
            pie.Price = 100;

            //Console.Write(pie.Name + ", ");
            //Console.Write(pie.Price + "Eur, ");
            //Console.WriteLine($"Expiration date: {pie.ExpirationTime.Date.ToString().Substring(0, 10)}");

            // Exercise 1.5.------------------
            Electronic pixelEightPro = new Electronic();
            pixelEightPro.Name = "Google Pixel 8 Pro";
            pixelEightPro.Price = 1100;

            //Console.Write(pixelEightPro.Name + ", ");
            //Console.Write(pixelEightPro.Price + "Eur, ");
            //Console.WriteLine($"Expiration date: {pixelEightPro.Warranty.Date.ToString().Substring(0, 10)}");

            // Exercise 1.6.------------------

        }
    }
}

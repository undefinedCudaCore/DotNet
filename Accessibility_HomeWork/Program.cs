namespace Accessibility_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.SetSalary(1500);
            //Console.WriteLine(employee.GetSalary());

            Manager manager = new Manager(1700);
            manager.NameAndSurename = "Steve";

            Console.WriteLine("First employee-----------------");
            Console.WriteLine(manager.NameAndSurename);
            Console.WriteLine("Salary at all: " + manager.GetSalary());

            Programmer programmer = new Programmer(1500);
            //Console.WriteLine(programmer.GetSalary());


            Tom tom = new Tom(18, 1200);
            tom.NameAndSurename = "Tom and Jerry";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Second employee-----------------");
            Console.WriteLine(tom.NameAndSurename);
            Console.WriteLine("Salary at all: " + tom.GetSalary());
        }
    }
}

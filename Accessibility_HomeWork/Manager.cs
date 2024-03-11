namespace Accessibility_HomeWork
{
    internal class Manager : Employee
    {
        public Manager(double salary)
        {
            Rand = new Random();
            _salary = salary;
        }

        public double Bonus { get; set; }
        public Random Rand { get; set; }

        public sealed override double GetSalary()
        {
            Bonus = Rand.Next(50, 500);
            Console.WriteLine("-----------------");
            Console.WriteLine("Bonus to salsary: " + Bonus);
            Console.WriteLine("-----------------");
            _salary += Bonus;
            return _salary;
        }
    }
}

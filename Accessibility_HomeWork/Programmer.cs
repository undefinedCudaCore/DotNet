namespace Accessibility_HomeWork
{
    internal class Programmer : Employee
    {
        public Programmer(double salary)
        {
            Rand = new Random();
            _salary = salary;
        }

        public double Bonus { get; set; }
        public Random Rand { get; set; }

        public sealed override double GetSalary()
        {
            Bonus = Rand.Next(50, 500);
            _salary += (Bonus * 2);
            return _salary;
        }
    }
}

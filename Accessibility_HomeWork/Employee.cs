namespace Accessibility_HomeWork
{
    internal class Employee
    {
        public string NameAndSurename { get; set; }
        protected double _salary { get; set; }

        public virtual double GetSalary()
        {
            return _salary;
        }
        public virtual double SetSalary(double salary)
        {
            _salary = salary;
            return _salary;
        }
    }
}

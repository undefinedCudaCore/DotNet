namespace Accessibility_HomeWork
{
    internal class Tom : Manager
    {
        public Tom(int age, double salary) : base(salary)
        {
            Age = age;
            _salary = salary;
        }

        public int Age { get; set; }
    }
}

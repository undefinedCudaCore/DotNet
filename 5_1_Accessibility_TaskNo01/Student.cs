namespace _5_1_Accessibility_TaskNo01
{
    internal class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;

            Random random = new Random();
            StudentId = random.Next(10000, 99999);
        }

        private int StudentId { get; set; }

        public int GetStudentId()
        {
            return StudentId;
        }
    }
}

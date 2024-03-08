namespace _5_1_Accessibility_TaskNo01
{
    internal class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
            _subject = GenerateSubject();
        }

        private string _subject;

        public string GetSubject()
        {
            return _subject;
        }

        private string GenerateSubject()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 6);
            List<string> subjectList = new List<string>()
            {
                "Mathemathics",
                "Biology",
                "History",
                "Foreign language",
                "English",
                "Science"
            };

            return subjectList[randomNumber];
        }
    }
}
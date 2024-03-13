namespace TaskNo03_Additional
{
    internal class Employee : Person
    {
        public Employee(string type, string name, string sureName, string position, string gender, string hairStyle, int age) : base(type, name, sureName, hairStyle, age)
        {
            Name = name;
            SureName = sureName;
            Position = position;
            Gender = gender;
            Type = type;
            HairStyle = hairStyle;
            Age = age;
        }

        public int Salary { get; set; }
        public int WorkHoursOfTheWeek { get; set; }
        public int EmotionalCondition { get; set; }

        public override void WhatDoesTheFoxSay()
        {
            Console.WriteLine("Give me more work!!!");
        }
    }
}
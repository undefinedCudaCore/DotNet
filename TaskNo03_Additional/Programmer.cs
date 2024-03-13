namespace TaskNo03_Additional
{
    internal class Programmer : Employee
    {
        public Programmer(string type, int salary, int workHoursOfTheWeek, int emotionalCondition, string name, string sureName, string position, string gender, string hairStyle, int age) : base(type, name, sureName, position, gender, hairStyle, age)
        {
            Name = name;
            SureName = sureName;
            Position = position;
            Gender = gender;
            Type = type;
            HairStyle = hairStyle;
            Age = age;
            Salary = salary;
            WorkHoursOfTheWeek = workHoursOfTheWeek;
            EmotionalCondition = emotionalCondition;
        }
        public int ProgrammingLanguage { get; set; }

        public override void WhatDoesTheFoxSay()
        {
            Console.WriteLine("I'm gonna be a game maker!!! Programming...");
        }
    }
}

namespace TaskNo03_Additional
{
    internal abstract class Person
    {
        protected Person(string type, string name, string sureName, string hairStyle, int age)
        {
            Type = type;
            Name = name;
            SureName = sureName;
            HairStyle = hairStyle;
            Age = age;
        }

        public string Name { get; set; }
        public string SureName { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string HairStyle { get; set; }
        public int Age { get; set; }

        public abstract void WhatDoesTheFoxSay();
    }
}
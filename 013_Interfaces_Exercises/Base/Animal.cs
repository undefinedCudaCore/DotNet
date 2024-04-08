namespace _013_Interfaces_Exercises.Base
{
    public class Animal
    {
        public Animal(int age, string name, string color)
        {
            Age = age;
            Name = name;
            Color = color;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}

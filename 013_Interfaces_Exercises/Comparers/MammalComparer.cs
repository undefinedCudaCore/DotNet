using _013_Interfaces_Exercises.Animals;

namespace _013_Interfaces_Exercises.Comparers
{
    internal class MammalComparer : IComparable<Dog>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public int CompareTo(Dog? other)
        {
            return String.Compare(Color, other.Color);
        }
    }
}

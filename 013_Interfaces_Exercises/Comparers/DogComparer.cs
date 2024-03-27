using _013_Interfaces_Exercises.Animals;

namespace _013_Interfaces_Exercises.Comparers
{
    internal class DogComparer : IComparer<Dog>
    {
        public int Compare(Dog? x, Dog? y)
        {
            return string.Compare(x.Color, y.Color);
        }
    }
}

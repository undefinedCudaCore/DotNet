using _013_Interfaces_Exercises.Animals;

namespace _013_Interfaces_Exercises.Comparers
{
    internal class CatComparer : IComparer<Cat>
    {
        public int Compare(Cat? x, Cat? y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}

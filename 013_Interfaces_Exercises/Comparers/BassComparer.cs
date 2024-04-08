using _013_Interfaces_Exercises.Animals;

namespace _013_Interfaces_Exercises.Comparers
{
    internal class BassComparer : IComparer<Bass>
    {
        public int Compare(Bass? x, Bass? y)
        {
            return string.Compare(x.Age.ToString(), y.Age.ToString());
        }
    }
}

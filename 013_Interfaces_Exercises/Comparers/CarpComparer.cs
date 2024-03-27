using _013_Interfaces_Exercises.Animals;

namespace _013_Interfaces_Exercises.Comparers
{
    internal class CarpComparer : IComparer<Carp>
    {
        public int Compare(Carp? x, Carp? y)
        {
            return string.Compare(x.Age.ToString(), y.Age.ToString());
        }
    }
}

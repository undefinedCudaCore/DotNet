using _012_Interfaces_Exercises.Cars;

namespace _012_Interfaces_Exercises.Comparers
{
    internal class AudiCarComparer : IComparer<AudiCar>
    {
        public int Compare(AudiCar x, AudiCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}

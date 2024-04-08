using _012_Interfaces_Exercises.Cars;

namespace _012_Interfaces_Exercises.Comparers
{
    internal class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar x, BmwCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}

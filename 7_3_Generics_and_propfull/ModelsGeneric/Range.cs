namespace _7_3_Generics_and_propfull.ModelsGeneric
{
    public class Range<T> where T : IComparable<T>
    {
        public T Start { get; set; }
        public T End { get; set; }

        public bool IsWithinRange(T value)
        {
            return value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0;
        }
    }
}
namespace _7_3_2_Exercise
{
    public class Validation<T>
    {
        private readonly T _validateList;
        //private readonly Dictionary<T1, T2> _validateCityList;

        public Validation(T validateList)
        {
            _validateList = validateList;
        }

        public static bool Validate(T value)
        {
            string type = "System.Collections.Generic.Dictionary`2[System.Int32,System.String]";

            if (value == null)
            {
                return true;
            }
            if (value.GetType().ToString() == type)
            {
                return true;
            }

            return false;
        }

        //public static bool Validate(T2 value)
        //{
        //    if (value == null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}

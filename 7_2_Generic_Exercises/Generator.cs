namespace _7_2_Generic_Exercises
{
    internal static class Generator<T>
    {
        public static void Show(T obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}

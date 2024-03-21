namespace _10_1_Anonymous_functions
{
    internal class Program
    {
        public delegate List<int> GetNumberList(List<int> list, int number2);
        public delegate string MyGeneric<T>(T element);

        static void Main(string[] args)
        {

            List<int> ints = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            GetNumberList del = delegate (List<int> list, int number2)
            {
                List<int> result = new List<int>();
                for (int i = 1; i < list.Count; i = i + number2)
                {
                    result.Add(list[i]);
                }
                return result;
            };

            foreach (var item in del(ints, 2))
            {
                Console.WriteLine(item);
            }

            MyGeneric<int> delType = delegate (int value)
            {
                return value.GetType().ToString();
            };

            Console.WriteLine(delType(5));
        }
    }
}

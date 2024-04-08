namespace _014_Func_Action_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colorsList = new List<string>();
            colorsList.Add("blue");
            colorsList.Add("red");
            colorsList.Add("orange");
            colorsList.Add("aqua");
            colorsList.Add("green");
            colorsList.Add("white");
            colorsList.Add("black");

            Func<string, string> f = (string i) =>
            {
                return i;
            };

            colorsList = colorsList.OrderBy(f).ToList();

            Action<int, int> abc = (int i, int j) =>
            {
                Console.WriteLine(i + j);
                Console.WriteLine($"i -> {i}");
                Console.WriteLine($"j -> {j}");
            };

            MakeActionWithActionDelegate(1, 2, abc);
        }

        public static void MakeActionWithActionDelegate(int a, int b, Action<int, int> print)
        {
            print(a, b);
        }
    }
}
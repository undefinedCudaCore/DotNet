namespace DelegateExercise01
{
    internal class Program
    {
        public delegate string PersonA(string fistName, string lastName, int age);
        public delegate int GetNumber(int number1, int number2);
        public delegate List<int> GetNumberList(List<int> list, int number2);
        public delegate string MyGeneric<T>(T element);

        static void Main(string[] args)
        {
            var person = new PersonA(ReturnString);
            string printPerson = person("Tadas", "Blinda", 55);
            Console.WriteLine(printPerson);

            var myNuber = new GetNumber(ReturnNumber);
            int printMyNumber = myNuber(5, 10);
            Console.WriteLine(printMyNumber);

            List<int> ints = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16
            };

            var delegateList = new GetNumberList(ReturnList);
            List<int> newList = delegateList(ints, 2);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            var genericDelegate1 = new MyGeneric<string>(GetType);
            Console.WriteLine(genericDelegate1("w"));

            var genericDelegate2 = new MyGeneric<int>(GetType);
            Console.WriteLine(genericDelegate2(5));

            var genericDelegate3 = new MyGeneric<char>(GetType);
            Console.WriteLine(genericDelegate3('s'));
        }

        public static string ReturnString(string fistName, string lastName, int age)
        {
            return $"My name is {fistName} {lastName}, I'm {age} years old.";
        }

        public static int ReturnNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        public static List<int> ReturnList(List<int> list, int num2)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < list.Count; i = i + num2)
            {
                result.Add(list[i]);
            }
            return result;
        }

        public static string GetType<T>(T element)
        {
            return element.GetType().ToString();
        }
    }
}

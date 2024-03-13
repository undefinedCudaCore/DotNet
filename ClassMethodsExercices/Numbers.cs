namespace ClassMethodsExercices
{
    internal class Numbers
    {
        public Numbers()
        {
            NumberList = new List<int>();
        }

        List<int> NumberList { get; set; }

        public List<int> AddNumberToList(int number)
        {
            NumberList.Add(number);

            return NumberList;
        }

        public void PrintNumbers()
        {
            foreach (int numberFromList in NumberList)
            {
                Console.WriteLine(numberFromList);
            }
        }
    }
}

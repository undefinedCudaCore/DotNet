namespace ClassMethodsExercices
{
    internal class Book
    {
        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string author, int pages) : this(title)
        {
            Author = author;
            Pages = pages;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        private double CountHowLongReadBook()
        {
            if (Pages > 50)
            {
                return Math.Round((double)Pages / 50, 2);
            }
            else
            {
                return double.NaN;
            }
        }

        public void PrintHowLongReadBook()
        {
            double count = CountHowLongReadBook();

            if (double.IsNaN(count))
            {
                Console.WriteLine("You will read this book in less than an hour.");
            }
            else
            {
                Console.WriteLine($"You will read this book in {count} hour.");
            }
        }
    }
}

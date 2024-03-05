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
        private DateTime CountWhenBoookWillBeReaded()
        {
            double timeToRead = 0;
            if (Pages > 50)
            {
                timeToRead = Math.Round((double)Pages / 50, 2);
            }
            else
            {
                timeToRead = -1;
            }
            return DateTime.Now.AddHours(timeToRead);
        }

        public void PrintHowLongReadBook()
        {
            double count = CountHowLongReadBook();

            if (double.IsNaN(count))
            {
                Console.Write("You will read this book in less than an hour.");
                Console.WriteLine(CountWhenBoookWillBeReaded() + ".");
            }
            else
            {
                Console.Write($"You will read this book in {count} hour, or on ");
                Console.WriteLine(CountWhenBoookWillBeReaded() + ".");
            }

        }
    }
}

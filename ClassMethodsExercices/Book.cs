namespace ClassMethodsExercices
{
    internal class Book
    {
        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string author, string pages) : this(title)
        {
            Author = author;
            Pages = pages;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Pages { get; set; }
    }
}

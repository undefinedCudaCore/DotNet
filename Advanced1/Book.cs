namespace Advanced1
{
    public class Book
    {
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal int Year { get; set; }
        internal string BookReleaseCountry { get; set; }

        internal Book(string Title, string Author, int Year, string BookReleaseCountry)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
            this.BookReleaseCountry = BookReleaseCountry;
        }

        public static List<Book> SearchForAuthor(List<Book> books, string author)
        {
            List<Book> newBookObjectList = new List<Book>();

            for (int i = 0; i < books.Count; i++)
            {
                if (author == books[i].Author)
                {
                    newBookObjectList.Add(books[i]);
                }
            }

            return newBookObjectList;
        }
    }
}

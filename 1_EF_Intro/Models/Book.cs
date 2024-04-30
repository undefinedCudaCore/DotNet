namespace _1_EF_Intro.Models
{
    internal class Book
    {
        public Book(int bookId)
        {
            BookId = bookId;
        }

        public Book(string name, List<Page> pages)
        {
            Name = name;
            Pages = pages;
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public List<Page> Pages { get; set; }
    }
}

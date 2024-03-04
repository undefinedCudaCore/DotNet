namespace ClassMethodsExercices
{
    internal class Library
    {

        public Library()
        {
            Books = new List<Book>();
        }

        //List<string> Books;
        List<Book> Books;

        public List<Book> AddBook(Book bookTitle)
        {
            Books.Add(bookTitle);

            return Books;
        }

        public List<Book> RemoveBook(Book bookTitle)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (bookTitle.Title == Books[i].Title)
                {
                    Books.RemoveAt(i);
                }
            }
            return Books;
        }

        public void GetBooksPrinted()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}

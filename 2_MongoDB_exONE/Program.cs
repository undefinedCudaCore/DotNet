using _2_MongoDB_exONE.Models;
using _2_MongoDB_exONE.Service;
using MongoDB.Driver;

namespace _2_MongoDB_exONE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient(connectionString: "mongodb+srv://undefinedcudacore:12H8H7K22zx+_)(" +
                "@learncluster.o4mzeso.mongodb.net/?retryWrites=true&w=majority");
            List<string> databases = client.ListDatabaseNames().ToList();

            var bookCollection = client.GetDatabase("Book").GetCollection<Book>("Book");
            var filter = Builders<Book>.Filter.Eq("BookName", "Good book");
            var update = Builders<Book>.Update.Set("BookName", "Good book2");
            var updatePage = Builders<Book>.Update.AddToSet<string>("BookPages", "aaa"); ;

            var book = new Book("Good book");
            var page1 = new Page("Childe vile his his call mood could aisle he parasites eros in were more once coffined glare ne shrine as then night break name time loved but like was harolds none climes scene can if control thence fellow childe perchance to superstition scorching break so een he in coffined harold");
            var page2 = new Page("In was would sacred fabled adversity den had ere it then did his festal mine crime there he yet alone deemed fulness for parasites long along with oh een and oft him the name ungodly");
            var page3 = new Page("In dares he from one and aught found albions are who and but thence his goodly had basked amiss he");

            book.BookPages.Add(page1);
            book.BookPages.Add(page2);
            book.BookPages.Add(page3);

            var book2 = new Book("Good book2");
            page1 = new Page("Childe vile his his call mood could aisle he parasites eros in were more once coffined glare ne shrine as then night break name time loved but like was harolds none climes scene can if control thence fellow childe perchance to superstition scorching break so een he in coffined harold");
            page2 = new Page("In was would sacred fabled adversity den had ere it then did his festal mine crime there he yet alone deemed fulness for parasites long along with oh een and oft him the name ungodly");
            page3 = new Page("In dares he from one and aught found albions are who and but thence his goodly had basked amiss he");

            book2.BookPages.Add(page1);
            book2.BookPages.Add(page2);
            book2.BookPages.Add(page3);

            BookRepository bookRepository = new BookRepository();
            //bookRepository.AddBook(book2, bookCollection);
            //bookRepository.AddBook(book, bookCollection);
            //bookRepository.RemoveBook(bookCollection, filter);
            //bookRepository.UpdateBook(bookCollection, filter, update);

            var result = bookRepository.FindBook(bookCollection, filter);

            foreach (var bookF in result)
            {
                Console.WriteLine(bookF.Id);
                Console.WriteLine(bookF.BookName);

                foreach (var page in bookF.BookPages)
                {
                    Console.WriteLine(page.Content);
                    Console.WriteLine("----");
                }
            }
        }
    }
}

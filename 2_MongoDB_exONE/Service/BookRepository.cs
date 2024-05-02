using _2_MongoDB_exONE.Models;
using MongoDB.Driver;

namespace _2_MongoDB_exONE.Service
{
    internal class BookRepository
    {
        public Book AddBook(Book book, IMongoCollection<Book> bookCollection)
        {
            bookCollection.InsertOne(book);

            return book;
        }

        public void RemoveBook(IMongoCollection<Book> bookCollection, FilterDefinition<Book> filter)
        {
            bookCollection.DeleteOne(filter);
        }

        public void UpdateBook(IMongoCollection<Book> bookCollection, FilterDefinition<Book> filter, UpdateDefinition<Book> update)
        {
            bookCollection.UpdateOne(filter, update);
        }

        public List<Book> FindBook(IMongoCollection<Book> bookCollection, FilterDefinition<Book> filter)
        {
            var result = bookCollection.Find(filter).ToList();

            return result;
        }

    }
}

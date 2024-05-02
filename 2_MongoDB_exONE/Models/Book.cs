using MongoDB.Bson;

namespace _2_MongoDB_exONE.Models
{
    public class Book
    {
        public Book(string bookName)
        {
            BookName = bookName;
            BookPages = new List<Page>();
        }

        public ObjectId Id { get; set; }
        public string BookName { get; set; }
        public List<Page> BookPages { get; set; }
    }
}

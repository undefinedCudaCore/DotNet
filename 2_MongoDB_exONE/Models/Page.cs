using MongoDB.Bson;

namespace _2_MongoDB_exONE.Models
{
    public class Page
    {
        public Page(string content)
        {
            Content = content;
        }

        public ObjectId Id { get; set; }
        public string Content { get; set; }
    }
}

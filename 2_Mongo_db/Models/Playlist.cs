using MongoDB.Bson;

namespace _2_Mongo_db.Models
{
    public class Playlist
    {
        public Playlist(string userName)
        {
            UserName = userName;
            Items = new List<string>();
        }

        public ObjectId Id { get; set; }
        public string UserName { get; set; }

        public List<string> Items { get; set; }
        public string FavouriteGenre { get; set; }
    }
}

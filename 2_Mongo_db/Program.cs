using _2_Mongo_db.Models;
using MongoDB.Driver;

namespace _2_Mongo_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient(connectionString: "mongodb+srv://undefinedcudacore:12H8H7K22zx+_)(" +
                "@learncluster.o4mzeso.mongodb.net/?retryWrites=true&w=majority");
            List<string> databases = client.ListDatabaseNames().ToList();

            //foreach (var database in databases)
            //{
            //    Console.WriteLine(database);
            //}

            var playlistColl = client.GetDatabase("Playlist").GetCollection<Playlist>("Playlist");

            //Insert

            //var playlist = new Playlist("Justas");

            //var songs = new List<string>()
            //{
            //    "Juoda Orchideja"
            //};
            //playlist.Items = songs;
            //playlist.FavouriteGenre = "POP";
            //playlistColl.InsertOne(playlist);

            //Select
            var filter = Builders<Playlist>.Filter.Eq("UserName", "Justas");
            var results = playlistColl.Find(filter).ToList();
            Console.WriteLine(results[0].FavouriteGenre);

            //Delete



            //Update
        }
    }
}

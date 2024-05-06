namespace _3_1_003_Many_to_many.Models
{
    internal class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public IList<Genre> Genres { get; set; }
    }
}
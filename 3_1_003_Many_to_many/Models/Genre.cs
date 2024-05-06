namespace _3_1_003_Many_to_many.Models
{
    internal class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public IList<Movie> Movies { get; set; }
    }
}

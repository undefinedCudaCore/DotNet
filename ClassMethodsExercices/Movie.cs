namespace ClassMethodsExercices
{
    internal class Movie
    {
        public Movie(string title, string genre, int rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }

        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public void PrintCanIWatchMovieIfItsRatingBiggerThanFive()
        {
            Console.WriteLine($"You can watch movie {Title}.");
        }
    }
}

namespace ClassMethodsExercices
{
    internal class Netflix
    {
        public Netflix()
        {
            Movies = new List<Movie>();
        }

        List<Movie> Movies { get; set; }

        public List<Movie> AddMovie(Movie movie)
        {
            Movies.Add(movie);

            return Movies;
        }

        public void PrintMovieWithGoodRating()
        {
            foreach (Movie movie in Movies)
            {
                if (movie.Rating > 5)
                {
                    movie.PrintCanIWatchMovieIfItsRatingBiggerThanFive();
                }
            }
        }
    }
}

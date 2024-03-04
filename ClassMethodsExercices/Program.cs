namespace ClassMethodsExercices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise NO 01--------------------
            Numbers number = new Numbers();
            Numbers number2 = new Numbers();

            number.AddNumberToList(5);
            number.AddNumberToList(555);
            number.AddNumberToList(96);

            number2.AddNumberToList(26);
            number2.AddNumberToList(226);

            //number.PrintNumbers();
            //number2.PrintNumbers();

            //Exercise NO 02--------------------
            Rectangle rectangle = new Rectangle(8, 12);

            //Console.WriteLine($"Rectangle area is: {rectangle.Area()}");
            //Console.WriteLine($"Rectangle perimeter is: {rectangle.Perimeter()}");

            //Exercise NO 03--------------------
            Circle circle = new Circle(5);

            //Console.WriteLine($"Circle area is: {Math.Round(circle.Area(), 2)}");
            //Console.WriteLine($"Circle perimeter is: {Math.Round(circle.Perimeter(), 2)}");

            //Exercise NO 04--------------------
            Library library = new Library();

            //library.AddBook(new Book("The book title"));
            //library.AddBook(new Book("The Unbearable Lightness of Being"));
            //library.AddBook(new Book("The book title"));
            //library.AddBook(new Book("The Hollow Chocolate Bunnies of the Apocalypse"));
            //library.AddBook(new Book("The book title"));
            //library.AddBook(new Book("Are You There, Vodka? It's Me, Chelsea"));

            //library.GetBooksPrinted();

            //Console.WriteLine("--------------------");
            //Book bookToRemove = new Book("The book title");

            //library.RemoveBook(bookToRemove);

            //library.GetBooksPrinted();

            //Exercise NO 05--------------------

            Playlist playlist = new Playlist();

            playlist.AddSong(new Song("Beatles", "Yesturday"));
            playlist.AddSong(new Song("This", "Bad song"));
            playlist.AddSong(new Song("Beatles", "Saturday"));
            playlist.AddSong(new Song("This", "Bad song"));
            playlist.AddSong(new Song("Rytis Cicinas", "Love ship"));
            playlist.AddSong(new Song("This", "Bad song"));

            //playlist.GetSongsPrinted();

            //Console.WriteLine("--------------------");
            Song songToRemove = new Song("This", "Bad song");

            playlist.RemoveSong(songToRemove);

            //playlist.GetSongsPrinted();

            //Exercise NO 06--------------------
            Netflix netflix = new Netflix();

            netflix.AddMovie(new Movie("Terminator", "Action", 10));
            netflix.AddMovie(new Movie("Terminator2", "Action", 8));
            netflix.AddMovie(new Movie("Do you love me", "Action", 6));
            netflix.AddMovie(new Movie("Jocker", "Action", 2));

            //netflix.PrintMovieWithGoodRating();

            //Exercise NO 07--------------------

            Book firstBook = new Book("The Unbearable Lightness of Being", "firstAuthor", 658);
            Book secondBook = new Book("The Hollow Chocolate Bunnies of the Apocalypse", "secondAuthor", 48);
            Book thirdBook = new Book("The Hollow Chocolate Bunnies of the Apocalypse 2", "secondAuthor", 168);

            firstBook.PrintHowLongReadBook();
            secondBook.PrintHowLongReadBook();
            thirdBook.PrintHowLongReadBook();
        }
    }
}

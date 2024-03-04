namespace ClassMethodsExercices
{
    internal class Playlist
    {
        public Playlist()
        {
            Songs = new List<Song>();
        }

        List<Song> Songs { get; set; }

        public List<Song> AddSong(Song songTitle)
        {
            Songs.Add(songTitle);

            return Songs;
        }

        public List<Song> RemoveSong(Song songTitle)
        {
            for (int i = 0; i < Songs.Count; i++)
            {
                if (songTitle.Title == Songs[i].Title)
                {
                    Songs.RemoveAt(i);
                }
            }
            return Songs;
        }

        public void GetSongsPrinted()
        {
            foreach (Song song in Songs)
            {
                Console.WriteLine($"Author: {song.Author} - song: {song.Title}");
            }
        }
    }
}

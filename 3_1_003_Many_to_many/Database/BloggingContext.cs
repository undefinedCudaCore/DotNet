using _3_1_003_Many_to_many.Models;
using Microsoft.EntityFrameworkCore;

namespace _3_1_003_Many_to_many.Database
{
    internal class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            ConnectionString = "Data Source=LENOVOY520\\SQLEXPRESS;Initial Catalog=ManyToManyDB;" +
                "Integrated Security=True;Encrypt=False";
        }

        public string ConnectionString { get; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConnectionString);
    }
}

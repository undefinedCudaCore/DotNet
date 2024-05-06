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
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }

        //Konfiguruojame kodo r DB bendravim1, settingai, kokiu budu prisijungiama ir panasiai
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Konfiguruojam PK
            modelBuilder.Entity<AuthorBlog>().HasKey(ab => new { ab.AuthorId, ab.BlogId });


            //Konfiguruojam foreign key AuthorBlog -> Author
            modelBuilder.Entity<AuthorBlog>()
                .HasOne(ab => ab.Author)
                .WithMany(a => a.AuthorBlogs)
                .HasForeignKey(ab => ab.AuthorId);

            //Konfiguruojam foreign key AuthorBlog -> Blog
            modelBuilder.Entity<AuthorBlog>()
                .HasOne(ab => ab.Blog)
                .WithMany(a => a.AuthorBlogs)
                .HasForeignKey(ab => ab.BlogId);
        }
    }
}

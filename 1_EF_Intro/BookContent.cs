using _1_EF_Intro.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_EF_Intro
{
    internal class BookContent : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=LENOVOY520\\SQLEXPRESS;" +
                "Initial Catalog=IntroDB;Integrated Security=True;Encrypt=False");
    }
}
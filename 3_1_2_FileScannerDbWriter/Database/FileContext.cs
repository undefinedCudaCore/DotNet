using Microsoft.EntityFrameworkCore;

namespace _3_1_2_FileScannerDbWriter.Database
{
    internal class FileContext : DbContext
    {
        public FileContext()
        {
            ConnectionString = "Data Source=LENOVOY520\\SQLEXPRESS;Initial Catalog=FileDB;" +
                "Integrated Security=True;Encrypt=False";
        }

        public string ConnectionString { get; }

        public DbSet<Models.File> Files { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConnectionString);
    }
}

using Microsoft.EntityFrameworkCore;
using MyApp.Repository.Models;

namespace MyApp.Repository
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer($"Server=localhost;Database=EntityFramework;Trusted_Connection=True;");
    }
}

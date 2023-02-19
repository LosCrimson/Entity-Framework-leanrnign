using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurant.Models;

namespace Restaurant.Repository
{
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Table> Tables { get; set; }

        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) 
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer($"Server=(localdb)\\Bankomat;Database=EntityFramework;Trusted_Connection=True;");
    }
}

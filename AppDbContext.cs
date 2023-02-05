using BikeRent.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeRent.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=Main.db");
        public DbSet<Client> Clients { get; set; }
        public DbSet<Bike> Bikes { get; set; }
    }
}

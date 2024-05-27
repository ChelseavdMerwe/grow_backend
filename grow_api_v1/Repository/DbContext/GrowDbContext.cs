using grow_api_v1.Models;
using grow_api_v1.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace grow_api_v1.Repository.DbContext
{
    public class GrowDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public GrowDbContext(DbContextOptions<GrowDbContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Produce> Produce { get; set; }
    }
}
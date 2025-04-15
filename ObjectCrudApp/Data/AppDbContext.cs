// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using ObjectCrudApp.Models;

namespace ObjectCrudApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users {get;set;}
    }
}
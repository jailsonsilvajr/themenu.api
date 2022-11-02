using Microsoft.EntityFrameworkCore;
using TheMenu.Domain.Entities;
using TheMenu.Infrastructure.Config;

namespace TheMenu.Infrastructure.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
        }

        public DbSet<Product> Products { get; set; }
    }
}

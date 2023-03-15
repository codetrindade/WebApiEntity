using Microsoft.EntityFrameworkCore;
using WebApiEntity.Models;


namespace WebApiEntity.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Seed database with authors and books for demo
            new DbInitializer(builder).Seed();
        }
    }
}

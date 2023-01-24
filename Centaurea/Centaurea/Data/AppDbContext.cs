using Centaurea.Models;
using Microsoft.EntityFrameworkCore;
namespace Centaurea.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Concert> Concerts { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>().HasBaseType<Concert>();
            modelBuilder.Entity<ClassicalConcert>().HasBaseType<Concert>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

﻿using Centaurea_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Centaurea_Project.Data
{
    public class AppDbContext : Centaurea_ProjectContext
    {
        public DbSet<RegularConcert> RegularConcerts { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<ClassicalConcert> ClassicalConcerts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>().ToTable("Parties");
            modelBuilder.Entity<RegularConcert>().ToTable("RegularConcerts");
            modelBuilder.Entity<ClassicalConcert>().ToTable("ClassicalConcerts");
            base.OnModelCreating(modelBuilder);
        }
    }
}

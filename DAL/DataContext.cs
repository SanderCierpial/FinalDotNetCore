using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.ShoppingBags)
                .WithOne(e => e.Customer);
            modelBuilder.Entity<ShoppingBag>()
                .HasMany(c => c.ShoppingItems)
                .WithOne(e => e.ShoppingBag);
            modelBuilder.Entity<ShoppingItem>()
                .HasOne(c => c.Product);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShoppingBag> ShoppingBags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingItem> ShoppingItems { get; set; }

    }
}

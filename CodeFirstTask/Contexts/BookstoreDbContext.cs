using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Contexts
{
    public class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BookStoreDB;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(e =>
            { 
               e.Property(p => p.Title).IsRequired().HasMaxLength(200);
                e.Property(p => p.Price).HasColumnType("decimal(8,2)");
                e.Property(p => p.PublishedDate).IsRequired(false);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
    

}

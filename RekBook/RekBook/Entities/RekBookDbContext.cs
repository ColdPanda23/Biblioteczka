using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace RekBook.Entities
{
    public class RekBookDbContext : DbContext
    {
        private string _connectionString =
            "Server = DESKTOP-78KRHML\\MSSQLSERVER01;Database=RekBookDb;Trusted_Connection=True;";

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
          
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseNpgsql();
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class BorrowContext : DbContext
    {
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Reader> Readers { get; set; }

        public BorrowContext()
        { }
        public BorrowContext(DbContextOptions<BorrowContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrow>(m =>
            {
                m.ToTable("Borrow");
                m.HasKey(x => x.Id);
            }
            );

            modelBuilder.Entity<Book>(m =>
            {
                m.ToTable("Book");
                m.HasKey(x => x.Id);
            }
            );

            modelBuilder.Entity<Reader>(m =>
            {
                m.ToTable("Reader");
                m.HasKey(x => x.Id);
            }
            );
        }
    }
}

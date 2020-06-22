using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookContext()
        { }
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(m =>
            {
                m.ToTable("Book");
                m.HasKey(x => x.Id);
            }
            );
            
            modelBuilder.Entity<Author>(m =>
            {
                m.ToTable("Author");
                m.HasKey(x => x.Id);
            }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class PlaceContext : DbContext
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Book> Books { get; set; }

        public PlaceContext()
        { }
        public PlaceContext(DbContextOptions<PlaceContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Place>(m =>
            {
                m.ToTable("Place");
                m.HasKey(x => x.Id);
            }
            );

            modelBuilder.Entity<Book>(m =>
            {
                m.ToTable("Book");
                m.HasKey(x => x.Id);
            }
            );
        }
    }
}

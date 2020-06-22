using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class AuthorContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public AuthorContext()
        { }
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(m =>
            {
                m.ToTable("Author");
                m.HasKey(x => x.Id);
            }
            );
        }
    }
}

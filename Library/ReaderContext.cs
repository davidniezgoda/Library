using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class ReaderContext : DbContext
    {
        public DbSet<Reader> Readers { get; set; }

        public ReaderContext()
        { }
        public ReaderContext(DbContextOptions<ReaderContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reader>(m =>
            {
                m.ToTable("Reader");
                m.HasKey(x => x.Id);
            }
            );
        }
    }
}

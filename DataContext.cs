using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp.Model;

namespace WpfApp
{
    public class TestDataContext : DbContext
    {
        public TestDataContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<testModel> data { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<testModel>()
                .ToTable("testtable");

            modelBuilder.Entity<testModel>()
                    .Property(b => b.Id)
                    .HasColumnName("id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DOU
{
    public partial class DouCompaniesDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite(@"Data Source=Database/dou-companies.db;");
        }

        public virtual DbSet<CompanyModel> Companies { get; set; }
        public virtual DbSet<ReviewItemModel> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyModel>().ToTable("V_Companies");
            modelBuilder.Entity<ReviewItemModel>().ToTable("Reviews");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DOU_Companies_Web_Api.Models
{
    public partial class DouCompaniesDbContext : DbContext
    {
        public DouCompaniesDbContext()
        {
        }

        public DouCompaniesDbContext(DbContextOptions<DouCompaniesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyModel> Companies { get; set; }
        public virtual DbSet<ReviewItemModel> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CompanyModel>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Companies", "dou_companies");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReviewItemModel>(entity =>
            {
                entity.ToTable("Reviews", "dou_companies");

                entity.HasIndex(e => e.CompanyName)
                    .HasName("companyName");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("companyName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.TranslatedText)
                    .HasColumnName("translatedText")
                    .HasColumnType("longtext");
            });
        }
    }
}

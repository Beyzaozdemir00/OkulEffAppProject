using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OkulEffAppProject.Models;

namespace OkulEffAppProject
{
    public class OkulDbContext : DbContext
    {
        // DbSet'ler (Tablolar)
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQL Server bağlantı dizesi
            optionsBuilder.UseSqlServer(@"Data Source=.\MS2024;Initial Catalog=OkulEffAppProjectDb;Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API ile ilişkiler
            modelBuilder.Entity<OgrenciDers>()
                .HasKey(od => new { od.OgrenciId, od.DersId }); // Composite Key

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(od => od.OgrenciId);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDersler)
                .HasForeignKey(od => od.DersId);
        }
    }
}

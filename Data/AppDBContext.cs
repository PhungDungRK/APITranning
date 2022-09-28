using System;
using Microsoft.EntityFrameworkCore;
using NhanVienAPI.Models;


namespace NhanVienAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        //public DbSet<Author> duanrikkei { get; set; }
        public DbSet<NhanVien> nhanvienrikkei { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            // Define relationship between books and authors
            builder.Entity<NhanVien>()
                .Property(x => x.MaNV)
                .IsRequired();

            // Seed database with authors and books for demo
            new DbInitializer(builder).Seed();
        }
    }
}


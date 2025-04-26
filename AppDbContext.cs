using Microsoft.EntityFrameworkCore;

namespace DangVanTai.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhongBan> PhongBan { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien");
            modelBuilder.Entity<PhongBan>().ToTable("PhongBan");
        }
    }
}
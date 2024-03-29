using Microsoft.EntityFrameworkCore;
using RedisCachingProject.Domain.Entities;
using System.Diagnostics.Contracts;

namespace RedisCachingProject.Infrastructure
{
    public class RedisCacheDBContext : DbContext
    {
        public RedisCacheDBContext(DbContextOptions options) : base(options)
        {
        }

        protected RedisCacheDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình DB
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Xây dựng cấu trúc table - dữ liệu
            // Chạy 1 lần khi DB mới tạo
            base.OnModelCreating(modelBuilder);
        }

        // Khai báo các DBSet Table
        public DbSet<New> News { get; set; }
    }
}

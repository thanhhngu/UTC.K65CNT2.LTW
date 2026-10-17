using NhtLesson09Lab.Areas.Admins.Models;
using Microsoft.EntityFrameworkCore;

namespace NhtLesson09Lab.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Name: không trùng (unique index)
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Banner>().HasIndex(b => b.Name).IsUnique();
            modelBuilder.Entity<Blog>().HasIndex(b => b.Name).IsUnique();

            // Product -> Category (khóa ngoại, không cho xóa Category nếu còn Product)
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

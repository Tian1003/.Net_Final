using s1110834035_NetFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace s1110834035_NetFinal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ImgCarousel> ImgCarousels { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Photos> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // ImgCarousel 欄位資料
            modelBuilder.Entity<ImgCarousel>(entity =>
            {

                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.ImgF).HasMaxLength(100);
            });

            // 測試資料
            modelBuilder.Entity<ImgCarousel>().HasData(
                new ImgCarousel { Id = 1, ImgF = "part_1.jpg" },
                new ImgCarousel { Id = 2, ImgF = "part_2.jpg" },
                new ImgCarousel { Id = 3, ImgF = "part_3.jpg" },
                new ImgCarousel { Id = 4, ImgF = "part_4.jpg" }
            );

            // Users 欄位資料
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(100);
                entity.Property(e => e.RegistrationDate).IsRequired();
            });

            // Albums 欄位資料
            modelBuilder.Entity<Albums>(entity =>
            {
                entity.Property(e => e.AlbumName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(500);
                entity.Property(e => e.CreationDate).IsRequired();
                entity.Property(e => e.UserId).IsRequired();
            });

            // Photos 欄位資料
            modelBuilder.Entity<Photos>(entity =>
            {
                entity.Property(e => e.PhotoName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(500);
                entity.Property(e => e.UploadDate).IsRequired();
                entity.Property(e => e.FilePath).IsRequired().HasMaxLength(255);
                entity.Property(e => e.AlbumId).IsRequired();
                entity.Property(e => e.UserId).IsRequired();
            });

            // 测试数据
            modelBuilder.Entity<Users>().HasData(
                new Users { Id = 1, UserName = "Justin", Email = "hapopo35@gmail.com", Password = "a1", RegistrationDate = DateTime.Now },
                new Users { Id = 2, UserName = "Milly", Email = "user2@example.com", Password = "a2", RegistrationDate = DateTime.Now },
                new Users { Id = 3, UserName = "Lucy", Email = "user3@example.com", Password = "a3", RegistrationDate = DateTime.Now }
            );

            modelBuilder.Entity<Albums>().HasData(
    new Albums { Id = 1, AlbumName = "相簿1", Description = "相簿描述", CreationDate = DateTime.Now, UserId = 1, PhotoCount = 5 },
    new Albums { Id = 2, AlbumName = "相簿2", Description = "相簿描述", CreationDate = DateTime.Now, UserId = 2, PhotoCount = 1 },
    new Albums { Id = 3, AlbumName = "相簿3", Description = "相簿描述", CreationDate = DateTime.Now, UserId = 3, PhotoCount = 1 }
);


            modelBuilder.Entity<Photos>().HasData(
                new Photos { Id = 1, PhotoName = "photo1", Description = "photo1 description", UploadDate = DateTime.Now, FilePath = "img1.jpg", AlbumId = 1, UserId = 1 },
                new Photos { Id = 2, PhotoName = "photo2", Description = "photo2 description", UploadDate = DateTime.Now, FilePath = "img2.jpg", AlbumId = 2, UserId = 2 },
                new Photos { Id = 3, PhotoName = "photo3", Description = "photo3 description", UploadDate = DateTime.Now, FilePath = "img3.jpg", AlbumId = 3, UserId = 3 },
                new Photos { Id = 4, PhotoName = "photo4", Description = "photo3 description", UploadDate = DateTime.Now, FilePath = "img4.jpg", AlbumId = 1, UserId = 1 },
                new Photos { Id = 5, PhotoName = "photo5", Description = "photo3 description", UploadDate = DateTime.Now, FilePath = "img5.jpg", AlbumId = 1, UserId = 1 },
                new Photos { Id = 6, PhotoName = "photo6", Description = "photo3 description", UploadDate = DateTime.Now, FilePath = "img6.jpg", AlbumId = 1, UserId = 1 },
                new Photos { Id = 7, PhotoName = "photo7", Description = "photo3 description", UploadDate = DateTime.Now, FilePath = "img7.jpg", AlbumId = 1, UserId = 1 }
            );
        }
    }
}


using s1110834035_NetFinal.Models;
using Microsoft.EntityFrameworkCore;
namespace s1110834035_NetFinal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ImgCarousel> ImgCarousels { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Category 欄位資料
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.Memo).HasMaxLength(100);
            });

            //測試資料
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "茶飲", DisplayOrder = 1, Memo = "這是茶" },
            new Category { Id = 2, Name = "水果茶", DisplayOrder = 2, Memo = "這是茶" },
            new Category { Id = 3, Name = "咖啡", DisplayOrder = 3, Memo = "這是咖啡" }
            );


            //… (接續上頁
            //Product 欄位資料
            //測試資料
            modelBuilder.Entity<Product>().HasData
            (
            new Product{Id = 1,Name = "台灣水果茶",Price = 60,ImgF = "img1.jpg",Description = "天然的最好",CategoryId = 2},
            new Product{Id = 2,Name = "鐵觀音",Price = 35,ImgF = "img2.jpg",Description = "人生的味道",CategoryId = 1},
            new Product{Id = 3,Name = "美式咖啡",Price = 50,ImgF = "img1.jpg",Description = "悠閒的時光",CategoryId = 3},
            new Product{Id = 4,Name = "紅茶",Price = 30,ImgF = "img1.jpg",Description = "發酵與沉澱",CategoryId = 1}
            );



            //ImgCarousel欄位資料
            modelBuilder.Entity<ImgCarousel>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(100);
                entity.Property(e => e.ImgF).HasMaxLength(100);
            });

            //測試資料
            modelBuilder.Entity<ImgCarousel>().HasData
            (
            new ImgCarousel { Id = 1, ImgF = "part_1.jpg" },
            new ImgCarousel { Id = 2, ImgF = "part_2.jpg" },
            new ImgCarousel { Id = 3, ImgF = "part_3.jpg" },
            new ImgCarousel { Id = 4, ImgF = "part_4.jpg" }
            );


        }
    }
}
using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreShop.Models.Infrastructure.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.CategoryName).HasMaxLength(100);
            builder.Property(c => c.ImagePath).HasMaxLength(100);
            builder.HasData(
                new Category
                {
                    Id =1,
                    CategoryName = "Biography",
                    CreatedAt = DateTime.Now,
                    Description = "Bio",
                    ImagePath = "/img/category/bio.jpeg"
                }, 
                new Category
                {
                    Id =2,
                    CategoryName = "Comedy",
                    CreatedAt = DateTime.Now,
                    Description = "Comedy",
                    ImagePath = "/img/category/comedy.jpeg"
                }
                , 
                new Category
                {
                    Id =3,
                    CategoryName = "Political",
                    CreatedAt = DateTime.Now,
                    Description = "Political",
                    ImagePath = "/img/category/political.jpeg"
                },
                 new Category
                {
                    Id =4,
                    CategoryName = "Sport",
                    CreatedAt = DateTime.Now,
                    Description = "Sport",
                    ImagePath = "/img/category/sport.jpeg"
                },
                 new Category
                {
                    Id =5,
                    CategoryName = "Tragedi",
                    CreatedAt = DateTime.Now,
                    Description = "Tragedi",
                    ImagePath = "/img/category/tragedi.jpeg"
                });
        }
    }
}

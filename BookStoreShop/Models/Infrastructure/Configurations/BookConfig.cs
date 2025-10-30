using BookStoreShop.Models.Domain.Entities.BookAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreShop.Models.Infrastructure.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title).HasMaxLength(100);
            builder.Property(b => b.ImagePath).HasMaxLength(100);
            builder.Property(b => b.Author).HasMaxLength(100);
            builder.HasData(
                new Book()
                {
                    Id = 1,
                    Author = "Asghar Farhadi",
                    Title = "Seller",
                    CategoryId = 1,
                    CreatedAt = DateTime.Now,
                    ImagePath = "/img/books/seller.jpeg",
                    PageCount =200,
                    Price =200_000,
                    PublishYear = "1398",
                },
                new Book()
                {
                    Id = 2,
                    Author = "Soroush Sehat",
                    Title = "Breakfast with ",
                    CategoryId = 1,
                    CreatedAt = DateTime.Now,
                    ImagePath = "/img/books/zarrafeh.jpeg",
                    PageCount =200,
                    Price =200_000,
                    PublishYear = "1398",
                },
                new Book()
                {
                    Id =3,
                    Author = "Asghar Farhadi",
                    Title = "Hero",
                    CategoryId = 1,
                    CreatedAt = DateTime.Now,
                    ImagePath = "/img/books/hero.jpeg",
                    PageCount =200,
                    Price =200_000,
                    PublishYear = "1398",
                },
                new Book()
                {
                    Id =4,
                    Author = "Saead Roustaiee",
                    Title = "Metri Shish o nim",
                    CategoryId = 1,
                    CreatedAt = DateTime.Now,
                    ImagePath = "/img/books/metri.jpeg",
                    PageCount =200,
                    Price =200_000,
                    PublishYear = "1398",
                },
                new Book()
                {
                    Id = 5,
                    Author = "Asghar Farhadi",
                    Title = "Hotel",
                    CategoryId = 1,
                    CreatedAt = DateTime.Now,
                    ImagePath = "/img/books/hotel.jpeg",
                    PageCount =200,
                    Price =200_000,
                    PublishYear = "1398",
                }
                );

        }
    }
}

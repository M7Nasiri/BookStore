using BookStoreShop.Models.Domain.Entities.CategoryAgg;

namespace BookStoreShop.Models.Domain.Entities.BookAgg
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public string PublishYear { get; set; }

        public DateTime CreatedAt { get; set; }
        public string? CreatedAtFA { get; set; }

        //Navigation Property
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

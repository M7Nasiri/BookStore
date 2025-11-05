using BookStoreShop.Models.Domain.Entities.BookAgg;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreShop.Models.Domain.Entities.CategoryAgg
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<Book>? Books { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}

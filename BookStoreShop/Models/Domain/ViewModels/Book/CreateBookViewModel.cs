namespace BookStoreShop.Models.Domain.ViewModels.Book
{
    public class CreateBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public string PublishYear { get; set; }
        public int CategoryId { get; set; }

        public DateTime CreatedAt { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}

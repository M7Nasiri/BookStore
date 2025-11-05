namespace BookStoreShop.Models.Domain.Entities.BookAgg.ViewModels
{
    public class GetPagedBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public string PublishYear { get; set; }
        public string? CreatedAtFA { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
    }
}

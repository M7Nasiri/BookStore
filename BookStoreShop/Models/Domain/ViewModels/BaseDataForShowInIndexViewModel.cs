namespace BookStoreShop.Models.Domain.ViewModels
{
    public class BaseDataForShowInIndexViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        public string BookImagePath { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string CategoryImagePath { get; set; }
    }
}

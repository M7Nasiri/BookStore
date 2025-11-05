namespace BookStoreShop.Models.Domain.Entities.CategoryAgg.ViewModels
{
    public class GetCategoryViewModel
    {
        public int CategoriesId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string? CatImagePath { get; set; }
    }
}

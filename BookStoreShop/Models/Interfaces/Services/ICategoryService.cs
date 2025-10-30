using BookStoreShop.Models.Domain.Entities.CategoryAgg;

namespace BookStoreShop.Models.Interfaces.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategory(int categoryId);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        List<Category> GetFiveNewCategory();
    }
}

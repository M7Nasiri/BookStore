using BookStoreShop.Models.Domain.Entities.CategoryAgg;

namespace BookStoreShop.Models.Interfaces.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategory(int categoryId);
        bool CreateCategory(Category category);
        bool UpdateCategory(int id, Category category);
        List<Category> GetFiveNewCategory();
        bool Delete(int id, Category model);
    }
}

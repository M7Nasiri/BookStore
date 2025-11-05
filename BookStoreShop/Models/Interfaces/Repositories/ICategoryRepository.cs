using BookStoreShop.Models.Domain.Entities.CategoryAgg;

namespace BookStoreShop.Models.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category GetCategory(int categoryId);
        bool CreateCategory(Category category);
        bool UpdateCategory(int id, Category category);
        List<Category> GetFiveNewCategory();
        bool DeleteCategory(int id);
    }
}

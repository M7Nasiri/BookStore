using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using BookStoreShop.Models.Implementations.Repositories;
using BookStoreShop.Models.Interfaces.Repositories;
using BookStoreShop.Models.Interfaces.Services;

namespace BookStoreShop.Models.Implementations.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryService()
        {
            _categoryRepo = new CategoryRepository();
        }
        public bool CreateCategory(Category category)
        {
            return _categoryRepo.CreateCategory(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepo.GetAllCategories();
        }

        public Category GetCategory(int categoryId)
        {
            return _categoryRepo.GetCategory(categoryId);
        }

        public List<Category> GetFiveNewCategory()
        {
            return _categoryRepo.GetFiveNewCategory();
        }

        public bool UpdateCategory(Category category)
        {
            return _categoryRepo.UpdateCategory(category);
        }
    }
}

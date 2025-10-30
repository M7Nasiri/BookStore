using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using BookStoreShop.Models.Infrastructure.Persistence;
using BookStoreShop.Models.Interfaces.Repositories;

namespace BookStoreShop.Models.Implementations.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository()
        {
            _context = new AppDbContext();
        }
        public bool CreateCategory(Category category)
        {
            _context.Add(category);
            return _context.SaveChanges() > 0;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public List<Category> GetFiveNewCategory()
        {
            return _context.Categories.OrderByDescending(c => c.CreatedAt).Take(5).ToList();
        }

        public bool UpdateCategory(Category category)
        {
            _context.Update(category);
            return _context.SaveChanges() > 0;
        }
    }
}

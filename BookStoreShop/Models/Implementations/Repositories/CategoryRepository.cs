using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using BookStoreShop.Models.Infrastructure.Persistence;
using BookStoreShop.Models.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookStoreShop.Models.Implementations.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
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

        public bool UpdateCategory(int id,Category model)
        {
            var cat = _context.Categories.FirstOrDefault(c=>c.Id== id);
            if (cat != null)
            {
                cat.CategoryName = model.CategoryName;
                cat.ImagePath = model.ImagePath;
                cat.Description = model.Description;
            }
            return _context.SaveChanges() > 0;
        }
        public bool DeleteCategory(int id)
        {
            return _context.Categories.Where(u => u.Id == id).ExecuteDelete() > 0;
        }

    }
}

using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;
using BookStoreShop.Models.Implementations.Repositories;
using BookStoreShop.Models.Interfaces.Repositories;
using BookStoreShop.Models.Interfaces.Services;

namespace BookStoreShop.Models.Implementations.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IFileService _fileService;
        public CategoryService(ICategoryRepository categoryRepo, IFileService fileService)
        {
            _categoryRepo = categoryRepo;
            _fileService = fileService;
        }
        public bool CreateCategory(Category model)
        {
            if (model.ImageFile != null)
            {
                var imgSrc = _fileService.Upload(model.ImageFile, "Category");
                model.ImagePath = imgSrc;
            }
            model.CreatedAt = DateTime.Now;
            return _categoryRepo.CreateCategory(model);
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

        public bool UpdateCategory(int id,Category model)
        {
            var cat = GetCategory(id);
            var oldPath = cat.ImagePath;
            if (model.ImageFile != null)
            {
                _fileService.Delete(oldPath);
                var newPath = _fileService.Upload(model.ImageFile, "Category");
                model.ImagePath = newPath;
            }
            else
            {
                model.ImagePath = oldPath;
            }
            return _categoryRepo.UpdateCategory(id,model);
        }
        public bool Delete(int id, Category model)
        {
            if (model.ImagePath != null)
            {
                _fileService.Delete(model.ImagePath);
            }
            return _categoryRepo.DeleteCategory(id);
        }
    }
}

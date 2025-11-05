using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _catService;
        public CategoryController(ICategoryService catService)
        {
            _catService = catService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            _catService.CreateCategory(category);
            return RedirectToAction("Index", "User");
        }

        public IActionResult Edit(int id)
        {
            var model = _catService.GetCategory(id);
            if(model == null)
            {
                return View();
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Category model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _catService.UpdateCategory(model.Id, model);
            return RedirectToAction("Index", "User");
        }
        public IActionResult Delete(int id)
        {
            var cat = _catService.GetCategory(id);
            if (cat == null)
            {
                ViewBag.Error = "آیدی نامعتبر است .";
                return View();
            }
            return View(cat);
        }
        [HttpPost]
        public IActionResult Delete(Category model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _catService.Delete(model.Id,model);
            return RedirectToAction("Index", "User");
        }

    }
}

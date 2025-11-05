using BookStoreShop.Models.Domain.Entities.BookAgg.ViewModels;
using BookStoreShop.Models.Domain.ViewModels;
using BookStoreShop.Models.Implementations.Services;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStoreShop.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _catService;

        public BookController(IBookService bookService,ICategoryService categoryService)
        {
            _bookService = bookService;
            _catService = categoryService;
        }

        public IActionResult Index(int page=1, int pageSize=4)
        {
            var books = _bookService.Pagination(page,pageSize);
            return View(books);
        }
        public IActionResult Create() 
        {
            var cats = _catService.GetAllCategories();
            ViewBag.Categories = cats;
            ViewBag.Categories1 = new SelectList(cats, "Id", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBookViewModel model)
        {
            if (ModelState.IsValid)
            {
                _bookService.CreateBook(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}

using BookStoreShop.Models.Domain.ViewModels;
using BookStoreShop.Models.Implementations.Services;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _catService;

        public HomeController(IBookService bookService, ICategoryService categoryService)
        {
            _bookService = bookService;
            _catService = categoryService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetFiveNewCreatedBooks();
            var cats = _catService.GetFiveNewCategory();
            var newest = new NewestBooksAndCategories
            {
                Books = books,
                Categories = cats,
            };
            // BaseDataForShowInIndexViewModel model = 
            return View(newest);
        }
    }
}

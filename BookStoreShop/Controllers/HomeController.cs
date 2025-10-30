using BookStoreShop.Models.Domain.ViewModels;
using BookStoreShop.Models.Implementations.Services;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService bookService;
        private readonly ICategoryService catService;

        public HomeController()
        {
            bookService = new BookService();
            catService = new CategoryService();
        }

        public IActionResult Index()
        {
            var books = bookService.GetFiveNewCreatedBooks();
            var cats = catService.GetFiveNewCategory();
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

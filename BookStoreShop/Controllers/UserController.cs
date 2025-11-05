using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;
using BookStoreShop.Models.InMemory;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreShop.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        private readonly ICategoryService _catService;
        public UserController(IUserService userService, ICategoryService catService)
        {
            _userService = userService;
            _catService = catService;
        }


        public IActionResult Index()
        {
            var user = InMemoryDatabase.OnlineUser;
            if (user is not null && user.IsAdmin)
            {
                var users = _userService.GetAll();
                var categories = _catService.GetAllCategories();
                var usersAndCategories = new UsersAndCategoriesViewModel
                {
                    Categories = categories,
                    Users = users
                };
                return View(usersAndCategories);
            }
            return RedirectToAction("Unautorized");

        }
        public IActionResult Create()
        {
            var user = InMemoryDatabase.OnlineUser;
            if (user is not null && user.IsAdmin)
            {
                return View();
            }
            return RedirectToAction("Unautorized");
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if(!_userService.Create(model))
            {
                ViewBag.UserExist = "نام کاربری تکراری است .";
                return View(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {

            var oUser = InMemoryDatabase.OnlineUser;
            if (oUser is not null && oUser.IsAdmin)
            {
                var user = _userService.GetUserById(id);
                if (user == null)
                {
                    return View();
                }
                var model = new EditUserViewModel
                {
                    FullName = user.FullName,
                    Id = id,
                    Password = user.Password,
                    Role = user.Role,
                    UserImagePath = user.UserImagePath,
                };
                return View(model);
            }
            return RedirectToAction("Unautorized");
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _userService.Update(model.Id, model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var oUser = InMemoryDatabase.OnlineUser;
            if (oUser is not null && oUser.IsAdmin)
            {
                var user = _userService.GetUserById(id);
                var model = new DeleteUserViewModel
                {
                    FullName = user.FullName,
                    Id = id,
                    Role = user.Role,
                    UserImagePath = user.UserImagePath,
                    UserName = user.UserName,
                };
                return View(model);
            }
            return RedirectToAction("Unautorized");
        }

        [HttpPost]
        public IActionResult Delete(DeleteUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _userService.Delete(model.Id, model);
            return RedirectToAction("Index");
        }
        public IActionResult Unautorized()
        {
            return View();
        }

        public IActionResult Logout()
        {
            InMemoryDatabase.OnlineUser = null;
            return RedirectToAction("Index", "Home");
        }
    }
}

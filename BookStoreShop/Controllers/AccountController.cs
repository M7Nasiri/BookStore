using BookStoreShop.Models.Domain.Entities.UserAgg.Enums;
using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;
using BookStoreShop.Models.InMemory;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var result = _userService.Login(model.UserName, model.Password);
            if (result != null)
            {
                if (result.Role == Roles.Admin)
                {
                    InMemoryDatabase.OnlineUser = new OnlineUser
                    {
                        Id = result.Id,
                        Username = result.UserName,
                        IsAdmin = result.Role == Roles.Admin,
                    };
                    return RedirectToAction("Index", "User");
                }
                else if (result.Role == Roles.NormalUser)
                {
                    InMemoryDatabase.OnlineUser = new OnlineUser
                    {
                        Id = result.Id,
                        Username = result.UserName,
                        IsAdmin = result.Role == Roles.Admin,
                    };
                    return RedirectToAction("Index", "Home");
                }                
            }
            ViewBag.Error = "نام کاربری یا رمز عبور اشتباه است.";
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (_userService.Register(model))
            {
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Error = "مشکلی در ثبت نام بوجود آمده است.";
                return View(model);
            }
        }

    }
}

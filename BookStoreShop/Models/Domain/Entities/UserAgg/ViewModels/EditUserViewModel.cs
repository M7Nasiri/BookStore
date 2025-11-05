using BookStoreShop.Models.Domain.Entities.UserAgg.Enums;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string? Password { get; set; }
        public string? UserImagePath { get; set; }
        public Roles Role { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}

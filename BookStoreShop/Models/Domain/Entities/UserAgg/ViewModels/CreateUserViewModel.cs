using BookStoreShop.Models.Domain.Entities.UserAgg.Enums;

namespace BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels
{
    public class CreateUserViewModel
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? UserImagePath { get; set; }
        public Roles Role { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}

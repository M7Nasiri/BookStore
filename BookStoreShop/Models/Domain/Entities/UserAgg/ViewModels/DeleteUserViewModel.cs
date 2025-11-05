using BookStoreShop.Models.Domain.Entities.UserAgg.Enums;

namespace BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels
{
    public class DeleteUserViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string? UserImagePath { get; set; }
        public Roles Role { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}

using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg;
namespace BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels
{
    public class UsersAndCategoriesViewModel
    {
        public List<User>? Users { set; get; } = new();
        public List<Category>? Categories { set; get; } = new();
    }
}

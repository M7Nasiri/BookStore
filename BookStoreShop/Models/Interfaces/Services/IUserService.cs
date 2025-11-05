using BookStoreShop.Models.Domain.Entities.UserAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;

namespace BookStoreShop.Models.Interfaces.Services
{
    public interface IUserService
    {
        bool Create(CreateUserViewModel model);
        bool Delete(int id, DeleteUserViewModel model);
        bool Update(int id, EditUserViewModel model);
        List<Domain.Entities.UserAgg.User> GetAll();
        Domain.Entities.UserAgg.User GetUserById(int id);
        User Login(string userName, string password);
        bool Register(RegisterUserViewModel model);
    }
}

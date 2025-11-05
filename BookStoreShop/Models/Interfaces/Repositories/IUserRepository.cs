using BookStoreShop.Models.Domain.Entities.UserAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;

namespace BookStoreShop.Models.Interfaces.Repositories
{
    public interface IUserRepository
    {
        bool Create(CreateUserViewModel model);
        bool Delete(int id);
        bool Update(int id, EditUserViewModel model);
        List<User> GetAll();
        User GetUserById(int id);
        User Login(string userName, string password);
        bool Register(RegisterUserViewModel model);
        bool IsUserExist(string userName);
    }
}

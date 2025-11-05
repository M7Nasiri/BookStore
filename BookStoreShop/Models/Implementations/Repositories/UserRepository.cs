using BookStoreShop.Models.Domain.Entities.UserAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;
using BookStoreShop.Models.Infrastructure.Persistence;
using BookStoreShop.Models.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookStoreShop.Models.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool Create(CreateUserViewModel model)
        {
            var user = new User
            {
                FullName = model.FullName,
                UserName = model.UserName,
                Password = model.Password,
                Role = model.Role,
                UserImagePath = model.UserImagePath
            };
            _context.Users.Add(user);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            return _context.Users.Where(u => u.Id == id).ExecuteDelete()>0;
        }

        public List<User> GetAll()
        {
            if (_context == null)
            {
                throw new InvalidOperationException("کاربری وارد نشده است .");
            }
            return _context.Users?.ToList()??new List<User>();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u=>u.Id == id);
        }

        public bool IsUserExist(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public User Login(string userName, string password)
        {
            var user = _context.Users.FirstOrDefault(u=>u.UserName.Equals(userName) && u.Password == password);
            return user;
        }

        public bool Register(RegisterUserViewModel model)
        {
            var entity = new User
            {
                FullName = model.FullName,
                UserName = model.UserName,
                Password = model.Password,
                Role = model.Role,
                UserImagePath = model.UserImagePath,
            };
            _context.Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Update(int id, EditUserViewModel model)
        {
            var user = _context.Users.FirstOrDefault(u=> u.Id == id);
            if(user != null)
            {               
                user.Password = model.Password;
                user.FullName = model.FullName;
                user.Role = model.Role;
                user.UserImagePath = model.UserImagePath;
                return _context.SaveChanges() > 0;         
            }
            return false;
        }
    }
}

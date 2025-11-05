using BookStoreShop.Models.Domain.Entities.UserAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg.ViewModels;
using BookStoreShop.Models.Implementations.Repositories;
using BookStoreShop.Models.Interfaces.Repositories;
using BookStoreShop.Models.Interfaces.Services;
using NuGet.Packaging.Rules;

namespace BookStoreShop.Models.Implementations.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        public UserService(IUserRepository userRepository, IFileService fileService)
        {
            _userRepository = userRepository;
            _fileService = fileService;
        }
        public bool Create(CreateUserViewModel model)
        {
            if (_userRepository.IsUserExist(model.UserName))
            {
                return false;
            }
            if(model.ImageFile != null)
            {
                var imgSrc = _fileService.Upload(model.ImageFile, "Users");
                model.UserImagePath = imgSrc;
            }
            return _userRepository.Create(model);
        }

        public bool Delete(int id,DeleteUserViewModel model)
        {
         if(model.UserImagePath != null)
            {
                _fileService.Delete(model.UserImagePath);
            }   
            return _userRepository.Delete(id);
        }

        public List<User> GetAll()
        {
            try
            {
                return _userRepository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }    
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User Login(string userName, string password)
        {
            return _userRepository.Login(userName, password);
        }

        public bool Register(RegisterUserViewModel model)
        {
            if (_userRepository.IsUserExist(model.UserName))
            {
                return false;
            }
            if(model.ImageFile != null)
            {
                var imgSrc = _fileService.Upload(model.ImageFile, "Users");
                model.UserImagePath = imgSrc;
            }
            return _userRepository.Register(model);
        }

        public bool Update(int id, EditUserViewModel model)
        {
            var user = GetUserById(id);
            var oldPath = user.UserImagePath;
            if (model.ImageFile != null)
            {
                _fileService.Delete(oldPath);
                var newPath = _fileService.Upload(model.ImageFile, "Users");
                model.UserImagePath = newPath;
            }
            else{
                model.UserImagePath=oldPath;
            }
            var pass = string.IsNullOrEmpty(model.Password)?user.Password:model.Password;
            model.Password = pass;
            return _userRepository.Update(id, model);
        }
    }
}

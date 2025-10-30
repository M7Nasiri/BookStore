namespace BookStoreShop.Models.Interfaces.Services
{
    public interface IFileService
    {
        string Upload(IFormFile file, string folder);
    }
}

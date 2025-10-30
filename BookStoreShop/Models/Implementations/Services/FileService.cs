﻿using BookStoreShop.Models.Interfaces.Services;

namespace BookStoreShop.Models.Implementations.Services
{
    public class FileService : IFileService
    {
        public string Upload(IFormFile file, string folder)
        {

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", folder);

            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            var filePath = Path.Combine(uploadsFolder, uniqueFileName);


            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return $"\\{Path.Combine("Files", folder, uniqueFileName)}";
        }
    }
}

using BookStoreShop.Models.Domain.Entities.BookAgg;
using BookStoreShop.Models.Domain.Entities.CategoryAgg;

namespace BookStoreShop.Models.Domain.ViewModels
{
    public class NewestBooksAndCategories
    {
        public List<Entities.BookAgg.Book> Books { get; set; }
        public List<Category> Categories { get; set; }

    }
}

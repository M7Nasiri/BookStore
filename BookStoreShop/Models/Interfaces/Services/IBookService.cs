using BookStoreShop.Models.Domain.Entities.BookAgg;
using BookStoreShop.Models.Domain.ViewModels.Book;

namespace BookStoreShop.Models.Interfaces.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        List<GetPagedBookViewModel> Pagination(int page, int pageSize);
        Book GetBook(int bookId);
        bool CreateBook(CreateBookViewModel model);
        bool UpdateBook(Book book);
        List<Book> GetFiveNewCreatedBooks();
    }
}

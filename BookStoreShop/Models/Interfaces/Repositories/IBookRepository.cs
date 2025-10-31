using BookStoreShop.Models.Domain.Entities.BookAgg;
using BookStoreShop.Models.Domain.ViewModels.Book;

namespace BookStoreShop.Models.Interfaces.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBook(int bookId);
        bool CreateBook(CreateBookViewModel model);
        bool UpdateBook(Book book);
        List<Book> GetFiveNewCreatedBooks();
        bool IsBookExist(string title, string author, string publishYear);
        List<Book> GetAllBooksPagination(int page, int pageSize);
        int GetCount();

    }
}

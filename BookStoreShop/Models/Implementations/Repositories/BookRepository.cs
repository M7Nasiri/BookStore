using BookStoreShop.Models.Domain.Entities.BookAgg;
using BookStoreShop.Models.Domain.ViewModels.Book;
using BookStoreShop.Models.Infrastructure.Persistence;
using BookStoreShop.Models.Interfaces.Repositories;

namespace BookStoreShop.Models.Implementations.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository()
        {
            _context = new AppDbContext();
        }
        public bool CreateBook(CreateBookViewModel model)
        {
            var book = new Book
            {
                Title = model.Title,
                Author = model.Author,
                PublishYear = model.PublishYear,
                Price = model.Price,
                PageCount = model.PageCount,
                ImagePath = model.ImagePath,
                CreatedAt = DateTime.Now,
                CategoryId = model.CategoryId,
            };
            _context.Add(book);
            return _context.SaveChanges() > 0;
        }

        public List<Book> GetFiveNewCreatedBooks()
        {
            return _context.Books.OrderByDescending(b => b.CreatedAt).Take(5).ToList();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.OrderByDescending(b=>b.CreatedAt).ToList();
        }
        public int GetCount()
        {
            return _context.Books.Count();
        }

        public List<Book> GetAllBooksPagination(int page,int pageSize)
        {
            return _context.Books.OrderByDescending(b=>b.CreatedAt).Skip((page-1)*pageSize).Take(pageSize).ToList();
        }

        public Book GetBook(int bookId)
        {
            return _context.Books.FirstOrDefault(b => b.Id == bookId);
        }

        public bool UpdateBook(Book book)
        {
            _context.Update(book);
            return _context.SaveChanges() > 0;

        }

        public bool IsBookExist(string title,string author,string publishYear)
        {
             return _context.Books.Any(b=>b.Title == title && b.Author == author && b.PublishYear == publishYear);
        }
    }
}

using BookStoreShop.Models.Application.tools;
using BookStoreShop.Models.Domain.Entities.BookAgg;
using BookStoreShop.Models.Domain.ViewModels.Book;
using BookStoreShop.Models.Implementations.Repositories;
using BookStoreShop.Models.Interfaces.Repositories;
using BookStoreShop.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.CodeAnalysis.CSharp;
using NuGet.Protocol.Plugins;
using System.Collections.Generic;

namespace BookStoreShop.Models.Implementations.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepo;
        private readonly IFileService _fileService;
        public BookService()
        {
            _bookRepo = new BookRepository();
            _fileService = new FileService();
        }
        public bool CreateBook(CreateBookViewModel model)
        {
            if (_bookRepo.IsBookExist(model.Title,model.Author,model.PublishYear))
            {
                return false;
            }
            if(model.ImageFile != null)
            {
                var uploadSrc = _fileService.Upload(model.ImageFile,"Books");
                model.ImagePath = uploadSrc;
            }
            
            return _bookRepo.CreateBook(model);
        }

        public List<Book> GetFiveNewCreatedBooks()
        {
            var books =  _bookRepo.GetFiveNewCreatedBooks();
            //books.ForEach(book =>
            //    book.CreatedAtFA = book.CreatedAt.ToPersianString("yyyy/MM/dd"));
            return books;
        }

        public List<Book> GetAllBooks()
        {
            var books = _bookRepo.GetAllBooks();

            books.ForEach(book =>
                book.CreatedAtFA = book.CreatedAt.ToPersianString("yyyy/MM/dd"));

            return books;
        }

        public Book GetBook(int bookId)
        {
            var book = _bookRepo.GetBook(bookId);

            book.CreatedAtFA = book.CreatedAt.ToPersianString("yyyy/MM/dd");

            return book;
        }

        public bool UpdateBook(Book book)
        {
            return _bookRepo.UpdateBook(book);
        }

        public List<GetPagedBookViewModel> Pagination(int page=1, int pageSize=4)
        {
            var books = _bookRepo.GetAllBooksPagination(page,pageSize);
            //var books = _bookRepo.GetAllBooks();
            int totalPage = (int)Math.Ceiling(_bookRepo.GetCount()/(double)pageSize);
            //var pagedBooks =  books;
            var getBookViewModels = new List<GetPagedBookViewModel>();

            foreach(var b in books)
            {
                getBookViewModels.Add(new GetPagedBookViewModel()
                {
                    Title = b.Title,
                    Author = b.Author,
                    CreatedAtFA = b.CreatedAt.ToPersianString(""),
                    Id = b.Id,
                    ImagePath = b.ImagePath,
                    PageCount = b.PageCount,
                    Price = b.Price,
                    PublishYear = b.PublishYear,
                    Page = page,
                    PageSize = pageSize,
                    TotalPage = totalPage,
                });
            };
            return getBookViewModels;
        }

        public int GetCount()
        {
           return _bookRepo.GetCount();
        }
    }
}

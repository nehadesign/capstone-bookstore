using capstone.BS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace capstone.BS.Models.Repository
{
    public class BookRepository : IBookRepository
    {
        
        readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool AddBook(Book bookParam)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _appDbContext.Books.Include(b => b.Category);
        }

        public Book GetBookById(int bookIdParam)
        {

            return _appDbContext.Books.Where(book => book.BookId == bookIdParam).FirstOrDefault();

        }
        public IEnumerable<Book> GetFeaturedBooks()
        {
            return _appDbContext.Books.Where(b => b.IsFeatured).Take(4);
        }
    }
}

using capstone.BS.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace capstone.BS.Models.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int bookIdParam);

        bool AddBook(Book bookParam);

        IEnumerable<Book> GetFeaturedBooks();
    }
}

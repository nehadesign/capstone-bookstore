using capstone.BS.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace capstone.BS.Models.Repository
{
    public class MockBookRepository : IBookRepository
    {
        public IEnumerable<Book> AllBooks => new List<Book>
            {
                new Book
                {
                    Author = new Author{ Name = "Mark King" },
                    CategoryId = 1,
                    Name = "Another mouse in the trap, a night with a Cat",
                    Price = 26.85M,
                    ThumbnailImageUrl = "https://via.placeholder.com/200x275",
                    IsFeatured = true,
                },

                 new Book
                {
                    Author = new Author{ Name = "Victor Putin" },
                    CategoryId = 1,
                    Name = "A day in Italy",
                    Price = 25.85M,
                    ThumbnailImageUrl = "https://via.placeholder.com/200x275",
                    IsFeatured = true,
                }
                 ,

                 new Book
                {
                    Author = new Author{ Name = "Victor Putin" },
                    CategoryId = 1,
                    Name = "A day in Italy",
                    Price = 25.85M,
                    ThumbnailImageUrl = "https://via.placeholder.com/200x275",
                    IsFeatured = true,
                }
                 ,

                 new Book
                {
                    Author = new Author{ Name = "Victor Putin" },
                    CategoryId = 1,
                    Name = "A day in Italy",
                    Price = 25.85M,
                    ThumbnailImageUrl = "https://via.placeholder.com/200x275",
                    IsFeatured = true,
                }
            };
    

        public bool AddBook(Book bookParam)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return AllBooks;
        }

        public Book GetBookById(int bookIdParam)
        {

            return AllBooks.Where(x => x.BookId == bookIdParam).FirstOrDefault();

        }
        public IEnumerable<Book> GetFeaturedBooks()
        {
            return AllBooks.Where(x => x.IsFeatured == true).Take(4);
        }
    }
}

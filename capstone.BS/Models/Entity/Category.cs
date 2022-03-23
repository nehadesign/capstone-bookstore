using System.Collections.Generic;

namespace capstone.BS.Models.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Book> Book { get; set; }
    }
}
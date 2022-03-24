using System.Collections.Generic;

namespace capstone.BS.Models.Entity
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}
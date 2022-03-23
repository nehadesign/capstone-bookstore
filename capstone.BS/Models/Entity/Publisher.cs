using System.Collections.Generic;

namespace capstone.BS.Models.Entity
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.BS.Models.Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public DateTime PublishedOn { get; set; }
        public Inventory Inventory{ get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public bool IsDigitalAvailable { get; set; }
        public string DigitalCopyUrl { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
    }
}

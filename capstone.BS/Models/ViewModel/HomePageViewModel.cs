using capstone.BS.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.BS.Models.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        public IEnumerable<Book> FeaturedBooks { get; set; }
    }
}

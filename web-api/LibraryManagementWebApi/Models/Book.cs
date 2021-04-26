using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Models
{
    public class Book
    {
        //public int BookId { get; set; }
        public Guid BookId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Title { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}

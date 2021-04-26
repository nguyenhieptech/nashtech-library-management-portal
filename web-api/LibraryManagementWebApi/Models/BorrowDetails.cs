using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Models
{
    public class BorrowDetails
    {
        public BorrowRequest BorrowRequestId { get; set; }
        public Book BookId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Models
{
    public class BorrowRequest
    {
        //public int BorrowRequestId { get; set; }
        public Guid BorrowRequestId { get; set; }
        public DateTime BorrowDate { get; set; }
        public User UserId { get; set; }
        public int Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Models
{
    public class BorrowRecord //BorrowRecord model representing a record of a book borrowed by a member
    {
        public string Id { get; set; } // Unique identifier for the borrow record

        public string MemberId { get; set; } // Unique identifier for the member who borrowed the book

    }
}

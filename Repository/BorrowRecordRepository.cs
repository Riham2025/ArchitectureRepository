using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Repository
{
    class BorrowRecordRepository
    {
        private readonly FileContext _context; // File context for managing file operations

        private List<BorrowRecord> _records; // List to hold borrow records in memory

        public BorrowRecordRepository(FileContext context) // Constructor to initialize the repository with a file context
        {
            _context = context;
            _records = _context.LoadBorrowRecords();
        }
    }
}

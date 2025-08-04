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
            _context = context; // Assign the provided file context to the repository
            _records = _context.LoadBorrowRecords(); // Load borrow records from the file context into the repository's memory
        }

        public void Add(BorrowRecord record) // Method to add a new borrow record to the repository
        {
            _records.Add(record); // Add the new borrow record to the in-memory list of records
            _context.SaveBorrowRecords(_records); // Save the updated list of borrow records to the file context
        }

    }
}

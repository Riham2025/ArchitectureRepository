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

        public void Update(BorrowRecord record) // Method to update an existing borrow record in the repository
        {
            var index = _records.FindIndex(r => r.Id == record.Id); // Find the index of the record with the same Id as the provided record
            if (index != -1) // Check if the record exists in the list
            {
                _records[index] = record; // Update the record at the found index with the new record data
                _context.SaveBorrowRecords(_records); // Save the updated list of borrow records to the file context
            }
        }

        public List<BorrowRecord> GetAll() => _records; // Method to get all borrow records from the repository

        public BorrowRecord GetByBookAndMember(string bookId, string memberId) // Method to get a borrow record by book ID and member ID
        {
            return _records.FirstOrDefault(r => r.BookId == bookId && r.MemberId == memberId && r.ReturnDate == null); // Check if the record exists in the list
        }
    }

}
}

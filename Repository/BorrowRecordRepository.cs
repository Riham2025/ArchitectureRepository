using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Repository
{
    public class BorrowRecordRepository : IBorrowRecordRepository
    {
        private List<BorrowRecord> _records; // In-memory list to store borrow records

        public BorrowRecordRepository() // Constructor to initialize the borrow record repository
        {
            _records = FileContext.LoadBorrowRecords(); // Load borrow records from the file context into the repository's memory
        }

        public void Add(BorrowRecord record) // Method to add a new borrow record to the repository
        {
            _records.Add(record);
            FileContext.SaveBorrowRecords(_records); // Save the updated list of borrow records to the file context
        }

        public void Update(BorrowRecord record)
        {
            var index = _records.FindIndex(r => r.Id == record.Id);
            if (index != -1)
            {
                _records[index] = record;
                FileContext.SaveBorrowRecords(_records);
            }
        }

        public List<BorrowRecord> GetAll() => _records;

        public BorrowRecord GetByBookAndMember(string bookId, string memberId)
        {
            return _records.FirstOrDefault(r => r.BookId == bookId && r.MemberId == memberId && r.ReturnDate == null);
        }
    }

}


using librarymanagementArchitectureRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Services
{
    class LibraryService
    {
        private readonly IBookRepository _bookRepo; // Book repository for managing book operations
        private readonly IMemberRepository _memberRepo; // Member repository for managing member operations
        private readonly IBorrowRecordRepository _recordRepo;

    }
}

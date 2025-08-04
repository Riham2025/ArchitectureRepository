using librarymanagementArchitectureRepository.Models;
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
        private readonly IBorrowRecordRepository _recordRepo; // Borrow record repository for managing borrow records


        public LibraryService(IBookRepository bookRepo, IMemberRepository memberRepo, IBorrowRecordRepository recordRepo) // Constructor to initialize the library service with repositories
        {
            _bookRepo = bookRepo; // Assign the provided book repository to the service
            _memberRepo = memberRepo; // Assign the provided member repository to the service
            _recordRepo = recordRepo; // Assign the provided borrow record repository to the service
        }

        public void AddBook(Book book) // Method to add a new book to the library

        {
            _bookRepo.Add(book); // Add the new book to the book repository
            Console.WriteLine("Book added.");
        }

    }
}

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
            Console.WriteLine("Book added."); // Print confirmation message
        }

        public void RegisterMember(Member member) // Method to register a new member in the library
        {
            _memberRepo.Add(member); // Add the new member to the member repository
            Console.WriteLine("Member registered."); // Print confirmation message
        }

        public void BorrowBook(string bookId, string memberId) // Method to borrow a book from the library
       
            {
            var book = _bookRepo.GetById(bookId); // Get the book by its unique identifier
            if (book == null || !book.IsAvailable) // Check if the book exists and is available
           
            {
                Console.WriteLine("Book not available."); // Print error message if the book is not available
                return;
            }

            var member = _memberRepo.GetById(memberId); // Get the member by their unique identifier
            if (member == null) // Check if the member exists
            
            {
                Console.WriteLine("Member not found."); // Print error message if the member is not found
                return;
            }

            var record = new BorrowRecord // Create a new borrow record
            {
                Id = Guid.NewGuid().ToString(),
                BookId = bookId,
                MemberId = memberId,
                BorrowDate = DateTime.Now
            };


        }
    }
}
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
                Id = Guid.NewGuid().ToString(), // Generate a unique identifier for the record
                BookId = bookId, // Unique identifier for the book being borrowed
                MemberId = memberId, // Unique identifier for the member borrowing the book
                BorrowDate = DateTime.Now // Set the current date and time as the borrow date
            };

            book.IsAvailable = false; // Set the book's availability status to false, indicating it is currently borrowed
            _bookRepo.Update(book); // Update the book in the book repository with the new availability status
            _recordRepo.Add(record); // Add the new borrow record to the borrow record repository

            Console.WriteLine("Book borrowed."); // Print confirmation message
        }

        public void ReturnBook(string bookId, string memberId)// Method to return a borrowed book to the library
        
            {
            var record = _recordRepo.GetByBookAndMember(bookId, memberId); // Get the borrow record by book ID and member ID
            if (record == null) // Check if the borrow record exists
           
            {
                Console.WriteLine("No borrow record found."); // Print error message if no borrow record is found
                return;
            }


            record.ReturnDate = DateTime.Now; // Set the return date to the current date and time
            _recordRepo.Update(record); // Update the borrow record in the borrow record repository with the return date

            var book = _bookRepo.GetById(bookId);
            if (book != null)
            {
                book.IsAvailable = true;
                _bookRepo.Update(book);
            }

            Console.WriteLine("Book returned.");


        }



    }
}
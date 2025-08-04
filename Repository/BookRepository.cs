using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Repository
{
    class BookRepository
    {
        private readonly FileContext _context; // File context for managing file operations

        private List<Book> _books; // List to hold books in memory

        public BookRepository(FileContext context) // Constructor to initialize the repository with a file context
        {
            _context = context; // Assign the provided file context to the repository
            _books = _context.LoadBooks(); // Load books from the file context into the repository's memory
        }

        public List<Book> GetAll() => _books; // Method to get all books from the repository

        public Book GetById(string id) => _books.FirstOrDefault(b => b.Id == id); // Method to get a book by its unique identifier


        public void Add(Book book) // Method to add a new book to the repository
        {
           
            _books.Add(book); // Add the new book to the in-memory list of books
            _context.SaveBooks(_books); // Save the updated list of books to the file context
        }

        public void Update(Book book) // Method to update an existing book in the repository
        {
            var index = _books.FindIndex(b => b.Id == book.Id);
            if (index != -1)
            {
                _books[index] = book;
                _context.SaveBooks(_books);
            }
        }
    }
}

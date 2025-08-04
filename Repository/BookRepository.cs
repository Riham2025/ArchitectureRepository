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
        
    }
}

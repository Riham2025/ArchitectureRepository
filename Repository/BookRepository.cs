using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Repository
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books; // In-memory list to store books

        public BookRepository() 
        {
            _books = FileContext.LoadBooks(); // Load books from the file context into the repository's memory
        }

        public List<Book> GetAll() => _books; // Method to retrieve all books from the repository

        public Book GetById(string id) => _books.FirstOrDefault(b => b.Id == id); // Method to retrieve a book by its unique identifier

        public void Add(Book book) // Method to add a new book to the repository
        {
            _books.Add(book); // Add the book to the in-memory list
            FileContext.SaveBooks(_books); // Save the updated list of books to the file context
        }

        public void Update(Book book) // Method to update an existing book in the repository
        {
            var index = _books.FindIndex(b => b.Id == book.Id); // Find the index of the book to be updated
            if (index != -1) // Check if the book exists in the list
            {
                _books[index] = book; // Update the book at the found index
                FileContext.SaveBooks(_books); // Save the updated list of books to the file context
            }
        }
    }
}

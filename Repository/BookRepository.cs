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

        public Book GetById(string id) => _books.FirstOrDefault(b => b.Id == id);

        public void Add(Book book)
        {
            _books.Add(book);
            FileContext.SaveBooks(_books);
        }

        public void Update(Book book)
        {
            var index = _books.FindIndex(b => b.Id == book.Id);
            if (index != -1)
            {
                _books[index] = book;
                FileContext.SaveBooks(_books);
            }
        }
    }
}

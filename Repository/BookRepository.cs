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
        List<Book> GetAll(); // Method to get all books from the repository
        Book GetById(string id); // Method to get a book by its unique identifier

        void Add(Book book); // Method to add a new book to the repository

        void Update(Book book); // Method to update an existing book in the repository
    }
}

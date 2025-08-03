using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository
{
    public class FileContext // FileContext class for managing file operations in the library management system
    {
        public string BookFile = "books.txt"; // File path for storing book data

        public string MemberFile = "members.txt"; // File path for storing member data

        public string BorrowFile = "borrows.txt"; // File path for storing borrow records data

        public List<Book> LoadBooks() // Method to load books from the file
        {
            var books = new List<Book>(); // Initialize a list to hold books

        }
    }
}

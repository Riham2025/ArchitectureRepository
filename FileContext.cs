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
            if (!File.Exists(BookFile)) return books; // Return empty list if the file does not exist

            foreach (var line in File.ReadAllLines(BookFile)) // Read each line from the book file
            {
                var parts = line.Split('|'); // Split the line into parts using '|' as a delimiter
                books.Add(new Book // Create a new Book object and add it to the list
                {
                    Id = parts[0], // Unique identifier for the book
                    Title = parts[1], // Title of the book
                    Author = parts[2], // Author of the book


                }
            {


                
    }   }

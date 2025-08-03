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
                    IsAvailable = bool.Parse(parts[3]) // Availability status of the book

                });
            }
            return books; // Return the list of books loaded from the file
        }

        public void SaveBooks(List<Book> books) // Method to save books to the file
        {

            var lines = new List<string>(); // Initialize a list to hold lines for the file
            foreach (var book in books) // Iterate through each book in the list

                lines.Add($"{book.Id}|{book.Title}|{book.Author}|{book.IsAvailable}"); // Create a line for each book with its properties separated by '|'
            File.WriteAllLines(BookFile, lines); // Write all lines to the book file

        }
        public List<Member> LoadMembers() // Method to load members from the file
        {
            var members = new List<Member>();

            if (!File.Exists(MemberFile)) return members;// Return empty list if the file does not exist

            foreach (var line in File.ReadAllLines(MemberFile)) // Read each line from the member file
            {
                var parts = line.Split('|');  // Split the line into parts using '|' as a delimiter
                members.Add(new Member { Id = parts[0], Name = parts[1] }); // Create a new Member object and add it to the list
            }
            return members; // Return the list of members loaded from the file

        }

        public void SaveMembers(List<Member> members) // Method to save members to the file
        {
            var lines = new List<string>(); // Initialize a list to hold lines for the file
            foreach (var m in members)
                lines.Add($"{m.Id}|{m.Name}"); // Create a line for each member with its properties separated by '|'
            File.WriteAllLines(MemberFile, lines); // Write all lines to the member file

        }

        public List<BorrowRecord> LoadBorrowRecords() // Method to load borrow records from the file
       
        {
            var records = new List<BorrowRecord>(); // Initialize a list to hold borrow records
            if (!File.Exists(BorrowFile)) return records; // Return empty list if the file does not exist

        }




    }
}
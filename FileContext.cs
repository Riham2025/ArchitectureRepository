using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository // Namespace for the library management system file context
{
    public static class FileContext // FileContext class for managing file operations in the library management system
    {
        public static string BookFile = "books.json"; // File path for storing book data
        public static string MemberFile = "members.json"; // File path for storing member data
        public static string BorrowFile = "borrows.json"; // File path for storing borrow records


        private static JsonSerializerOptions options = new JsonSerializerOptions  
        {
            // Configure JSON serialization options
            WriteIndented = true
        };

        public static List<Book> LoadBooks() // Method to load books from the JSON file
        {
            if (!File.Exists(BookFile)) return new List<Book>(); // Check if the file exists, return an empty list if not
            string json = File.ReadAllText(BookFile); // Read the JSON content from the file
            return JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>(); // Deserialize the JSON content into a list of Book objects, return an empty list if deserialization fails
        }

        public static void SaveBooks(List<Book> books) // Method to save books to the JSON file
        {
            string json = JsonSerializer.Serialize(books, options); // Serialize the list of books to JSON format
            File.WriteAllText(BookFile, json); // Write the JSON content to the file
        }

        public static List<Member> LoadMembers() // Method to load members from the JSON file
        {
            if (!File.Exists(MemberFile)) return new List<Member>(); // Check if the file exists, return an empty list if not
            string json = File.ReadAllText(MemberFile); // Read the JSON content from the file
            return JsonSerializer.Deserialize<List<Member>>(json) ?? new List<Member>(); // Deserialize the JSON content into a list of Member objects, return an empty list if deserialization fails
        }

        public static void SaveMembers(List<Member> members) // Method to save members to the JSON file
        {
            string json = JsonSerializer.Serialize(members, options); // Serialize the list of members to JSON format
            File.WriteAllText(MemberFile, json); // Write the JSON content to the file
        }

        public static List<BorrowRecord> LoadBorrowRecords() // Method to load borrow records from the JSON file
        {
            if (!File.Exists(BorrowFile)) return new List<BorrowRecord>(); // Check if the file exists, return an empty list if not
            string json = File.ReadAllText(BorrowFile); // Read the JSON content from the file
            return JsonSerializer.Deserialize<List<BorrowRecord>>(json) ?? new List<BorrowRecord>(); // Deserialize the JSON content into a list of BorrowRecord objects, return an empty list if deserialization fails
        }

        public static void SaveBorrowRecords(List<BorrowRecord> records) // Method to save borrow records to the JSON file
        {
            string json = JsonSerializer.Serialize(records, options);
            File.WriteAllText(BorrowFile, json);
        }
    }

}  




    

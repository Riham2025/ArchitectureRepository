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
    }

}  




    

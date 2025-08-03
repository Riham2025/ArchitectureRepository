using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Models // namespace for the Book model
{
    public class Book // Book model representing a book in the library
    {
        public string Id { get; set; } // Unique identifier for the book
        public string Title { get; set; } // Title of the book
        public string Author { get; set; } // Author of the book

        public bool IsAvailable { get; set; } = true; // Availability status of the book
    }
}

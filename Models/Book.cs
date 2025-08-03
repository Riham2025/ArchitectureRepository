using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Models
{
    public class Book
    {
        public string Id { get; set; } // Unique identifier for the book
        public string Title { get; set; } // Title of the book
        public string Author { get; set; } // Author of the book
    }
}

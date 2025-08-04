using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Repository
{
    class MemberRepository
    {
        private readonly FileContext _context; // File context for managing file operations

        private List<Member> _members; // List to hold members in memory

        public MemberRepository(FileContext context) // Constructor to initialize the repository with a file context
        {
            _context = context; // Assign the provided file context to the repository
            _members = _context.LoadMembers(); // Load members from the file context into the repository's memory
        }

        public List<Member> GetAll() => _members; // Method to get all members from the repository

    }
}

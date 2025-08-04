using librarymanagementArchitectureRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementArchitectureRepository.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly FileContext _context; // File context for managing file operations

        private List<Member> _members; // List to hold members in memory

        public MemberRepository(FileContext context) // Constructor to initialize the repository with a file context
        {
            _context = context; // Assign the provided file context to the repository
            _members = _context.LoadMembers(); // Load members from the file context into the repository's memory
        }

        public List<Member> GetAll() => _members; // Method to get all members from the repository

        public Member GetById(string id) => _members.FirstOrDefault(m => m.Id == id); // Method to get a member by its unique identifier

        public void Add(Member member) // Method to add a new member to the repository
        {
            _members.Add(member); // Add the new member to the in-memory list of members
            _context.SaveMembers(_members); //  Save the updated list of members to the file context
        }


    }
}

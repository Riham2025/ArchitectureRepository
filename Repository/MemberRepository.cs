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
        private List<Member> _members; // In-memory list to store members

        public MemberRepository() // Constructor to initialize the member repository
        {
            _members = FileContext.LoadMembers(); // Load members from the file context into the repository's memory
        }

        public List<Member> GetAll() => _members; // Method to retrieve all members from the repository

        public Member GetById(string id) => _members.FirstOrDefault(m => m.Id == id); // Method to retrieve a member by their unique identifier

        public void Add(Member member) // Method to add a new member to the repository
        {
            _members.Add(member);
            FileContext.SaveMembers(_members);
        }


    }
}

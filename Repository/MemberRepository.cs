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
    }
}

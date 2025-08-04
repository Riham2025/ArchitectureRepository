using librarymanagementArchitectureRepository.Models;

namespace librarymanagementArchitectureRepository.Repository
{
    public interface IMemberRepository
    {
        void Add(Member member);
        List<Member> GetAll();
        Member GetById(string id);
    }
}
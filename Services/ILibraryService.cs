using librarymanagementArchitectureRepository.Models;

namespace librarymanagementArchitectureRepository.Services
{
    public interface ILibraryService
    {
        void AddBook(string Id, string Title, string Author, bool IsAvailable); 
        void BorrowBook(string bookId, string memberId);
        void RegisterMember(Member member);
        void ReturnBook(string bookId, string memberId);
    }
}
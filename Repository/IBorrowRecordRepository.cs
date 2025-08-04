using librarymanagementArchitectureRepository.Models;

namespace librarymanagementArchitectureRepository.Repository
{
    public interface IBorrowRecordRepository
    {
        void Add(BorrowRecord record);
        List<BorrowRecord> GetAll();
        BorrowRecord GetByBookAndMember(string bookId, string memberId);
        void Update(BorrowRecord record);
    }
}
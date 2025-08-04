using librarymanagementArchitectureRepository.Repository;
using librarymanagementArchitectureRepository.Services;

namespace librarymanagementArchitectureRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileContext = new FileContext(); // FileContext instance to manage file operations

            var bookRepo = new BookRepository(fileContext); // BookRepository instance to manage book data
            var memberRepo = new MemberRepository(fileContext);
            var recordRepo = new BorrowRecordRepository(fileContext);

            var service = new LibraryService(bookRepo, memberRepo, recordRepo);
        }
    }
}

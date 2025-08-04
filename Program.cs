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
            var memberRepo = new MemberRepository(fileContext); // MemberRepository instance to manage member data
            var recordRepo = new BorrowRecordRepository(fileContext);// BorrowRecordRepository instance to manage borrow records

            var service = new LibraryService(bookRepo, memberRepo, recordRepo);
        }
    }
}

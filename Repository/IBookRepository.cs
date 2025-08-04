using librarymanagementArchitectureRepository.Models;

namespace librarymanagementArchitectureRepository.Repository
{
    public interface IBookRepository
    {
        void Add(Book book);
        List<Book> GetAll();
        Book GetById(string id);
        void Update(Book book);
    }
}
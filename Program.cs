using librarymanagementArchitectureRepository.Models;
using librarymanagementArchitectureRepository.Repository;
using librarymanagementArchitectureRepository.Services;

namespace librarymanagementArchitectureRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileContext = new FileContext(); // FileContext instance to manage file operations

            IBookRepository bookRepo = new BookRepository(fileContext); 
            IMemberRepository memberRepo = new MemberRepository(fileContext); 
            IBorrowRecordRepository recordRepo = new BorrowRecordRepository(fileContext);

            var service = new LibraryService(bookRepo, memberRepo, recordRepo);

            // Main loop for the library menu
            while (true)
            {
                Console.WriteLine("\nLibrary Menu:"); // Display the library menu
                Console.WriteLine("1. Add Book"); // Add a new book to the library
                Console.WriteLine("2. Register Member"); // Register a new member in the library
                Console.WriteLine("3. Borrow Book"); // Borrow a book from the library
                Console.WriteLine("4. Return Book"); // Return a borrowed book to the library
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                switch (choice) 
                {
                    case "1": // Add a new book
                        Console.Write("Book ID: ");
                        var bookId = Console.ReadLine();
                        Console.Write("Title: ");
                        var title = Console.ReadLine();
                        Console.Write("Author: ");
                        var author = Console.ReadLine();
                        service.AddBook(new Book { Id = bookId, Title = title, Author = author });
                        break;

                    case "2": // Register a new member
                        Console.Write("Member ID: ");
                        var memberId = Console.ReadLine();
                        Console.Write("Name: ");
                        var name = Console.ReadLine();
                        service.RegisterMember(new Member { Id = memberId, Name = name });
                        break;

                    case "3": // Borrow a book
                        Console.Write("Book ID: ");
                        var bId = Console.ReadLine();
                        Console.Write("Member ID: ");
                        var mId = Console.ReadLine();
                        service.BorrowBook(bId, mId);
                        break;

                    case "4": // Return a borrowed book
                        Console.Write("Book ID: ");
                        var rbId = Console.ReadLine();
                        Console.Write("Member ID: ");
                        var rmId = Console.ReadLine();
                        service.ReturnBook(rbId, rmId);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}


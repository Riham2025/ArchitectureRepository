using librarymanagementArchitectureRepository.Models;
using librarymanagementArchitectureRepository.Repository;
using librarymanagementArchitectureRepository.Services;

namespace librarymanagementArchitectureRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookRepository bookRepo = new BookRepository(); // Repository for managing books in the library
            IMemberRepository memberRepo = new MemberRepository(); // Repository for managing members in the library
            IBorrowRecordRepository recordRepo = new BorrowRecordRepository(); // Repository for managing borrow records in the library

            ILibraryService service = new LibraryService(bookRepo, memberRepo, recordRepo); // Library service that uses the repositories to perform operations on books, members, and borrow records



            // Main loop for the library menu
            while (true)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Register Member");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Book ID: ");
                        string Id = Console.ReadLine();
                        Console.Write("Title: ");
                        string Title = Console.ReadLine();
                        Console.Write("Author: ");
                        string Author = Console.ReadLine();
                        service.AddBook( Id,  Title,  Author, true);
                        break;

                    case "2":
                        Console.Write("Member ID: ");
                        var memberId = Console.ReadLine();
                        Console.Write("Name: ");
                        var name = Console.ReadLine();
                        service.RegisterMember(new Member { Id = memberId, Name = name });
                        break;

                    case "3":
                        Console.Write("Book ID: ");
                        var bId = Console.ReadLine();
                        Console.Write("Member ID: ");
                        var mId = Console.ReadLine();
                        service.BorrowBook(bId, mId);
                        break;

                    case "4":
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
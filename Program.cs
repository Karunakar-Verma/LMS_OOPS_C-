using System;
using Libsystem.Models;

namespace Libsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create library
            Library library = new Library();

            // Add books
            Book b1 = new Book(1, "The Alchemist", "Paulo Coelho");
            Book b2 = new Book(2, "Clean Code", "Robert C. Martin");
            Book b3 = new Book(3, "Atomic Habits", "James Clear");

            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);

            // Register members
            Member m1 = new Member(101, "Karunakar");
            Member m2 = new Member(102, "Rohan");

            library.RegisterMember(m1);
            library.RegisterMember(m2);

            // Show all books
            library.ShowAllBooks();

            // Borrowing books through member
            m1.BorrowBook(b1);
            m1.BorrowBook(b2);
            m2.BorrowBook(b1); // Already borrowed

            // Returning and borrowing again
            m1.ReturnBook(b1);
            m2.BorrowBook(b1);

            // Show borrowed books for each member
            m1.ShowBorrowedBooks();
            m2.ShowBorrowedBooks();

            // Show updated library books
            library.ShowAllBooks();
        }
    }
}

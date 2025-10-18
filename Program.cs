using System;
using Libsystem.Models;

namespace Libsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some books
            Book b1 = new Book(1, "The Alchemist", "Paulo Coelho");
            Book b2 = new Book(2, "Clean Code", "Robert C. Martin");
            Book b3 = new Book(3, "Atomic Habits", "James Clear");

            // Create members
            Member m1 = new Member(101, "Karunakar");
            Member m2 = new Member(102, "Rohan");

            // Borrowing books
            m1.BorrowBook(b1);
            m1.BorrowBook(b2);
            m2.BorrowBook(b1); // Already borrowed, should show not available

            // Returning books
            m1.ReturnBook(b1);
            m2.BorrowBook(b1); // Now available again

            // Show borrowed books
            m1.ShowBorrowedBooks();
            m2.ShowBorrowedBooks();
        }
    }
}

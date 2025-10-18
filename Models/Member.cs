using System;
using System.Collections.Generic;

namespace Libsystem.Models
{
    public class Member
    {
        public int MemberId { get; }
        public string Name { get; }
        private List<Book> borrowedBooks = new List<Book>();

        public Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

        public void BorrowBook(Book book)
        {
            if (!book.IsAvailable)
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available right now.");
                return;
            }

            borrowedBooks.Add(book);
            book.MarkAsBorrowed();
            Console.WriteLine($"{Name} borrowed '{book.Title}'.");
        }

        public void ReturnBook(Book book)
        {
            if (!borrowedBooks.Contains(book))
            {
                Console.WriteLine($"{Name} did not borrow '{book.Title}'.");
                return;
            }

            borrowedBooks.Remove(book);
            book.MarkAsReturned();
            Console.WriteLine($"{Name} returned '{book.Title}'.");
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine($"\nBooks borrowed by {Name}:");
            if (borrowedBooks.Count == 0)
            {
                Console.WriteLine("No books borrowed.");
                return;
            }

            foreach (var book in borrowedBooks)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
}

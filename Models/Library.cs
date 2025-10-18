using System;
using System.Collections.Generic;

namespace Libsystem.Models
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RegisterMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member '{member.Name}' registered.");
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("\nAll Books in Library:");
            foreach (var book in books)
            {
                string status = book.IsAvailable ? "Available" : "Borrowed";
                Console.WriteLine($"- {book.Title} by {book.Author} ({status})");
            }
        }
    }
}
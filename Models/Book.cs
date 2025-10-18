using System;

namespace Libsystem.Models
{
    public class Book
    {
        public int BookId { get; }
        private string title;
        private string author;
        public bool IsAvailable { get; private set; } = true;


        public Book(int bookid, string title, string author)
        {
            BookId = bookid;
            this.title = title;
            this.author = author;

        }


        public string Title => title;
        public string Author => author;


        public void MarkAsBorrowed()
        {
            if (!IsAvailable)
            {
                Console.WriteLine("This book is already borrowed !");
                return;
            }
            else
            {
                IsAvailable = false;
                Console.WriteLine($"Book '{Title}' has been borrowed.");
            }
        }

        public void MarkAsReturned()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"Book '{Title}' was not borrowed.");
                return;
            }

            IsAvailable = true;
            Console.WriteLine($"Book '{Title}' has been returned.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"[{BookId}] {Title} by {Author}- {(IsAvailable ? "Available" : "Borrowed")}");
        }

    }
}
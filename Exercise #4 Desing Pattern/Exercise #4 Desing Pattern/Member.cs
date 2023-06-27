using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberId { get; set; }
        public string Email { get; set; }
        public List<LibraryItem> BorrowedBooks { get; set; }

        public Member()
        {
            BorrowedBooks = new List<LibraryItem>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Email: {Email}");

        }

        public void BorrowBook(LibraryItem book)
        {
            // Perform borrowing operations.
            book.LentToMemberId = MemberId;
            // Add any additional logic or update book status as needed.
            Console.WriteLine($"Book '{book.Title}' has been borrowed by {Name}.");
        }

        public void ReturnBook(LibraryItem book)
        {
            // Perform returning operations.
            book.LentToMemberId = 0;
            // Add any additional logic or update book status as needed.
            Console.WriteLine($"Book '{book.Title}' has been returned by {Name}.");
        }

    }
}

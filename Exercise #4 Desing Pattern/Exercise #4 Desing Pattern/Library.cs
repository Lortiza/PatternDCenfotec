using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public class Library
    {
        private List<LibraryItem> books;
        private List<Member> members;
        private IDataStorage dataStorage;

        public Library(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
            books = dataStorage.LoadLibrary()?.GetAllBooks() ?? new List<LibraryItem>();
            members = new List<Member>();
        }

        public Library()
        {
        }

        public void AddBook(LibraryItem book)
        {
            books.Add(book);
            SaveLibraryToDataStorage();
        }

        public List<LibraryItem> GetAllBooks()
        {
            return books;
        }

        public List<LibraryItem> SearchBooks(string query)
        {
            return books.Where(book =>
                book.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                book.Author.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        private bool IsBookAvailable(LibraryItem book)
        {
            return book.LentToMemberId == 0;
        }

        public void LendBook(LibraryItem book, Member member)
        {
            if (books.Contains(book))
            {
                // Check if the book is available for lending
                if (IsBookAvailable(book))
                {
                    // Perform lending operations
                    book.LentToMemberId = member.MemberId;
                    member.BorrowBook(book);
                    Console.WriteLine($"Book '{book.Title}' has been successfully lent to {member.Name}.");
                    SaveLibraryToDataStorage();
                }
                else
                {
                    Console.WriteLine($"Book '{book.Title}' is already lent out.");
                }
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' is not available in the library.");
            }
        }

        public void ReturnBook(LibraryItem book, Member member)
        {
            if (books.Contains(book))
            {
                if (book.LentToMemberId == member.MemberId)
                {
                    // Perform returning operations
                    book.LentToMemberId = 0;
                    member.ReturnBook(book);
                    Console.WriteLine($"Book '{book.Title}' has been successfully returned by {member.Name}.");
                    SaveLibraryToDataStorage();
                }
                else
                {
                    Console.WriteLine($"Book '{book.Title}' is not borrowed by {member.Name}.");
                }
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' is not available in the library.");
            }
        }

        private void SaveLibraryToDataStorage()
        {
            dataStorage.SaveLibrary(this);
        }
    }
}

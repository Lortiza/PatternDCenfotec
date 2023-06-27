using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public interface IBookOperations
    {
        void AddBook(Book book);
        void DisplayAllBooks();
        void SearchBookByTitle(string title);
        void SearchBookByAuthor(string author);
        void LendBook(Book book, Member member);
        void ReceiveBook(Book book, Member member);
    }
}

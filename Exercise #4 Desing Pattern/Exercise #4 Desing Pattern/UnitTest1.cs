namespace Exercise__4_Desing_Pattern
{
    public class UnitTest1
    {
        private Library _library;
        private MemoryDataStorage _dataStorage;

        public UnitTest1()
        {
            _dataStorage = new MemoryDataStorage();
            _library = new Library(_dataStorage);
        }


        [Fact]
        public void AddBook_BookAddedSuccessfully()
        {
            // Arrange
            LibraryItem book = new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger" };

            // Act
            _library.AddBook(book);

            // Assert
            Assert.Contains(book, _library.GetAllBooks());
        }

        [Fact]
        public void LendBook_BookLentSuccessfully()
        {
            // Arrange
            LibraryItem book = new Book { Title = "1984", Author = "George Orwell" };
            Member member = new Member { Name = "John Doe" };
            _library.AddBook(book);

            // Act
            _library.LendBook(book, member);

            // Assert
            Assert.Equal(member.MemberId, book.LentToMemberId);
            Assert.Contains(book, member.BorrowedBooks);
        }

        [Fact]
        public void ReturnBook_BookReturnedSuccessfully()
        {
            // Arrange
            LibraryItem book = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" };
            Member member = new Member { Name = "Jane Smith" };
            _library.AddBook(book);
            _library.LendBook(book, member);

            // Act
            _library.ReturnBook(book, member);

            // Assert
            Assert.Equal(0, book.LentToMemberId);
            Assert.DoesNotContain(book, member.BorrowedBooks);
        }

    }
}
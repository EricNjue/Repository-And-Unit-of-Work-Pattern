using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_UnitOfWorkPattern
{
    public class MockBooksRepo: IBooksRepository
    {
        public static List<Book> BookList = null;

        public MockBooksRepo()
        {
            //Initialize and add dummy books....
            BookList = new List<Book>();

            BookList.Add(new Book() { AuthorName = "Tony Consiglio", BookName = "110 Perc, $12.95", ISBN = "978-1-891830-75-4" });
            BookList.Add(new Book() { AuthorName = "F. Scott Fitzgerald", BookName = "The 120 Days of Simon, $14.95", ISBN = "978-1-60309-050-6" });
            BookList.Add(new Book() { AuthorName = "John Steinbeck", BookName = "A Matter of Life, $14.95", ISBN = "978-1-60309-266-1" });
            BookList.Add(new Book() { AuthorName = "Jeffrey Brown", BookName = "AEIOU or Any Easy Intimacy, $12.00", ISBN = "978-1-891830-71-6" });
            BookList.Add(new Book() { AuthorName = "George Orwell", BookName = "Alec: The Years Have Pants, $35.00", ISBN = "978-1-60309-025-4" });
            BookList.Add(new Book() { AuthorName = "James Joyce", BookName = "Alec: The Years Have Pants -- HARDCOVER, $49.95", ISBN = "978-1-60309-047-6" });
            BookList.Add(new Book() { AuthorName = "Vladimir Nabokov", BookName = "Alone Forever, $9.95", ISBN = "978-1-60309-322-4" });
            BookList.Add(new Book() { AuthorName = "Joseph Heller", BookName = "American Elf (Book 2), $19.95", ISBN = "978-1-891830-85-3" });
            BookList.Add(new Book() { AuthorName = "Toni Morrison", BookName = "Bacchus (Omnibus Edition): Volume One, $39.99", ISBN = "978-1-60309-016-2" });
            BookList.Add(new Book() { AuthorName = "Scott Morse", BookName = "The Barefoot Serpent (softcover), $14.95", ISBN = "978-1-60309-265-4" });
        }

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }

        public void DeleteBook(Book book)
        {
            BookList.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return BookList.ToList();
        }

        public Book GetBookById(int id)
        {
            return BookList.FirstOrDefault(w => w.ID == id);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(int id, Book book)
        {
            Book b = GetBookById(id);
            b = book;
        }
    }
}

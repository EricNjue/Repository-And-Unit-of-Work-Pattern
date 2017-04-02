using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_UnitOfWorkPattern
{
    public class BooksRepository : IBooksRepository, IDisposable
    {
        BooksDBEntities entities = new BooksDBEntities();

        #region IBooksRepository Members

        public BooksRepository()
        {
            entities = new BooksDBEntities();
        }

        public void AddBook(Book book)
        {
            entities.Books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            entities.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return entities.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return entities.Books.FirstOrDefault(w => w.ID == id);
        }

        public void Save()
        {
            entities.SaveChanges();
        }

        public void UpdateBook(int id, Book book)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                entities = null;
            }
        }

        ~BooksRepository()
        {
            Dispose(false);
        }
        #endregion
    }
}

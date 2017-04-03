using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_UnitOfWorkPattern
{
    public class BooksRepositoryEn : IBooksRepository
    {
        BooksDBEntities entities = null;

        public BooksRepositoryEn(BooksDBEntities entities)
        {
            this.entities = entities;
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
            Book b = GetBookById(id);
            b = book;
        }
    }
    
}

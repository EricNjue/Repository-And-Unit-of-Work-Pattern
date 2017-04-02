using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_UnitOfWorkPattern
{
    public class UnitOfWork : IDisposable
    {
        BooksDBEntities entities = null;

        public IBooksRepository BooksRepository { get; private set; }

        // This will be called from controller default constructor...
        public UnitOfWork()
        {
            entities = new BooksDBEntities();
            BooksRepository = new BooksRepositoryEn(entities);
        }

        // This will be created from test project and passed on to the
        // controllers parameterized constructors
        public UnitOfWork(IBooksRepository booksRepo)
        {
            BooksRepository = booksRepo;
        }

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

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}

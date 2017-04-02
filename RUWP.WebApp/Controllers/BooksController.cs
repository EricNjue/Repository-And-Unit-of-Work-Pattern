using Repository_UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RUWP.WebApp.Controllers
{
    public class BooksController : Controller
    {
        private IBooksRepository booksRepository = null;

        public BooksController() : this(new BooksRepository())
        {

        }

        public BooksController(BooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }

        // GET: Books
        public ActionResult Index()
        {
            List<Book> books = booksRepository.GetAllBooks();
            return View(books);
        }
    }
}
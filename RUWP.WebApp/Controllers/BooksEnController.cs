using Repository_UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RUWP.WebApp.Controllers
{
    public class BooksEnController : Controller
    {
        private UnitOfWork unitOfWork = null;

        public BooksEnController(UnitOfWork uow)
        {
            this.unitOfWork = uow;
        }

        public BooksEnController():this(new UnitOfWork())
        {

        }

        // GET: BooksEn
        public ActionResult Index()
        {
            List<Book> books = unitOfWork.BooksRepository.GetAllBooks();
            return View(books);
        }
    }
}
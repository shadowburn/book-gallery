using BookGallery.Data;
using BookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookGallery.Controllers
{
    public class BooksController : Controller
    {
        private BookRepository _bookRepository = null;

        public BooksController()
        {
            _bookRepository = new BookRepository();
        }

        public ActionResult Index()
        {
            var books = _bookRepository.GetBooks();

            return View(books);
        }

        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            var book = _bookRepository.GetBook(id.Value);

            return View(book);
        }
    }
}
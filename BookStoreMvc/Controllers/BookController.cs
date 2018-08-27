using BookStoreMvc.Models;
using BookStoreMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreMvc.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController()
        {
            _bookService = new BookService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<BookViewModel> bookViewModels = _bookService.GetAll();
            return View(bookViewModels);
        }
        [HttpGet]
        public ActionResult NewBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBoobk(BookViewModel book)
        {
            if (ModelState.IsValid)
            {
                _bookService.AddNewBook(book);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpPost()]
        public ActionResult RemoveBook(string name)
        {
            _bookService.RemoveBook(name);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateBook(string number)
        {
                BookViewModel bookViewModel = _bookService.GetById(number);
                return View(bookViewModel); 
        }
        [HttpPost]
        public ActionResult UpdateBook(BookViewModel model)
        {
            _bookService.UpdateBook(model);
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book

        [HttpGet]
        public ActionResult Add_Book()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add_Book(Book b)
        {
            b.Add();
            return View();
        }
        public ActionResult ShowAll()
        {
            return View(new Book().ShowAll());
        }

        public ActionResult Update(string isbn)
        {
            Book b = new Book();
            b.ISBN = isbn;
            Book search_Book = b.Search();
            return View(search_Book);
        }
        [HttpPost]
        public ActionResult update(Book b)
        {
            b.update();
            return RedirectToAction("ShowAll");


        }
        [HttpGet]
        public ActionResult Delete(string isbn)
        {
            Book b = new Book();
            b.ISBN = isbn;
            b.Delete();

            return RedirectToAction("ShowAll");
        }
    }
}
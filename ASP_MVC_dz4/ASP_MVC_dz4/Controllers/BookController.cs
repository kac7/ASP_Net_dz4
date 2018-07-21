using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_dz4.Models;

namespace ASP_MVC_dz4.Controllers
{
    public class BookController : Controller
    {
        IRepository<Book> book = BookRepository.Instanse;
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create() => View();
        [HttpPost]
        public ActionResult Create(Book value, string Publisher, string[] Authors)
        {
            value.Id = BookRepository.Instanse.Count++;
            foreach (var item in PublisherRepository.Instanse._publishers)
            {
                if (item.Name == Publisher)
                {
                    value.Publisher = item;
                }
            }
            foreach (var item in AuthorRepository.Instanse._authors)
            {
                if (Authors != null)
                {
                    foreach (var item2 in Authors)
                    {
                        if (item.Name == item2)
                        {
                            value.AddAuthor(item);
                            break;
                        }
                    }
                }
            }
            book.Add(value);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.newbook = book.Get(id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, Book value, string Publisher, string[] Authors)
        {
            book.Get(id).Name = value.Name;
            book.Get(id).PageCount = value.PageCount;
            book.Get(id).ISBN = value.ISBN;
            book.Get(id).PublishDate = value.PublishDate;
            foreach (var item in PublisherRepository.Instanse._publishers)
            {
                if (item.Name == Publisher)
                {
                    book.Get(id).Publisher = item;
                }
            }

            book.Get(id).Authors = Enumerable.Empty<Author>();

            foreach (var item in AuthorRepository.Instanse._authors)
            {
                if (Authors != null)
                {
                    foreach (var item2 in Authors)
                    {
                        if (item.Name == item2)
                        {
                            book.Get(id).AddAuthor(item);
                            break;
                        }
                    }
                }
            }

            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            book.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
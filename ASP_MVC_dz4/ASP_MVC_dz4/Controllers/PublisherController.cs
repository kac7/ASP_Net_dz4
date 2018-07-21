using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_MVC_dz4.Models;

namespace ASP_MVC_dz4.Controllers
{
    public class PublisherController : Controller
    {
        IRepository<Publisher> publisher = PublisherRepository.Instanse;
        // GET: Publisher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create() => View();
        [HttpPost]
        public ActionResult Create(Publisher value)
        {
            value.Id = PublisherRepository.Instanse.Count++;
            publisher.Add(value);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id) {

            ViewBag.newPublisher = publisher.Get(id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, Publisher value)
        {
            publisher.Get(id).Name = value.Name;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            foreach (var item in BookRepository.Instanse._books)
            {
                if (item.Publisher.Id == id)
                {
                    item.Publisher.Clear();
                }
            }
            publisher.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
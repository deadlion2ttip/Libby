using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Libby.Models;

namespace Libby.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/BlindDate
        public ActionResult BlindDate()
        {
            var book = new Book() {Name = "Dances With Wolves" };

            return View(book);
        }

        //GET: Books/Edit/ID
        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        // GET: Books
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Libby.Models;
using Libby.ViewModels;

namespace Libby.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books/BlindDate
        public ActionResult BlindDate()
        {
            var book = new Book() {Name = "Dances With Wolves" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1", Id = 1},
                new Customer {Name = "Customer 2", Id = 2 }
            };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers
            };
            return View(viewModel);
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

        [Route("books/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}
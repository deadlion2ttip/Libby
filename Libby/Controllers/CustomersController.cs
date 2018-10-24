using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Libby.Models;
using Libby.ViewModels;

namespace Libby.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new CustomerIndexViewModel()
            {
                Customers = new List<Customer>
            {
                new Customer(){ Name = "John Adams", Id = 1 },
                new Customer(){ Name = "Thomas Jefferson",Id = 2}
            }
            };


            return View(customers);
        }

        [Route("Customers/{CustomerId}")]
        public ActionResult ViewCustomer(int CustomerId)
        {
            Customer customer = new Customer();
            if (CustomerId == 1)
            {
                customer.Name = "John Adams";
            }
            if (CustomerId == 2)
            {
                customer.Name = "Thomas Jefferson";
            }

            customer.Id = CustomerId;
            return View(customer);
        }
    }
}
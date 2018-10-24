using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Libby.Models;

namespace Libby.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
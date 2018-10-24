using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        readonly List<Customer> customers = new List<Customer>
        {
            new Customer{Name = "John Smith", Id = 1},
            new Customer{Name = "Mary Williams", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.SingleOrDefault(c => c.Id == id);
            if (customer is null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}
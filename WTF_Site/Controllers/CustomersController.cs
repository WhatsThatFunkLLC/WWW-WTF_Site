using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WTF_Site.Models;

namespace WTF_Site.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //The proper way to dispose of the dbcontext
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers;

            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }
}
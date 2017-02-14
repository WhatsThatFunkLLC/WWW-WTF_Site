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
        private appplicationdb

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        private IEnumerable<Customer> GetCustomers()
        {
            
        }
    }
}
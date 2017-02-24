using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WTF_Site.Models;
using System.Data.Entity;
using WTF_Site.ViewModels;

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
            var customers = _context.Customers.Include(x => x.MembershipType);

            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            if(id == null || id < 1)
            {
                return HttpNotFound();
            }

            var customer = _context.Customers.Include(x => x.MembershipType).ToList().SingleOrDefault(x => x.Id == id);

            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(NewCustomerViewModel viewModel)
        {
            return View();
        }

    }
}
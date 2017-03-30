using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using WTF_Site.Models;
using WTF_Site.Services;
using WTF_Site.ViewModels;

namespace WTF_Site.Controllers
{
    public class ComicsController : Controller
    {
        private ApplicationDbContext _context;
        private IComicService _comicService;

        public ComicsController()
        {
            _context = new ApplicationDbContext();
            _comicService = new ComicService();
        }

        // GET: Comics
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var comics = _context.Comics.Include(x => x.Genre);

            return View(comics);
        }

        public ActionResult Details(int? id)
        {
            if(id == null || id < 1)
            {
                return HttpNotFound();
            }

            var comic = _context.Comics.Include(x => x.Genre).SingleOrDefault(x => x.Id == id);
           
            return View(comic);
           
        }

        public ActionResult New()
        {
            var membershipTypes = _context.Genre;
            var viewModel = new ComicFormViewModel
            {
                Comic = new Comic(),
                Genres = membershipTypes
            };

            return View("ComicForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Comic comic)
        {
            if(!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                var viewModel = new ComicFormViewModel
                {
                    Comic = comic,
                    Genres = _context.Genre.ToList()
                };
                return View("ComicForm", viewModel);
            }

            if (comic.Id == 0)
            {
                _context.Comics.Add(comic);
            }
            else
            {
                var comicInDb = _context.Comics.Single(c => c.Id == comic.Id);

                comicInDb.Title = comic.Title;
                comicInDb.Price = comic.Price;
                comicInDb.ReleaseDate = comic.ReleaseDate;
                comicInDb.GenreId = comic.GenreId;
                comicInDb.Summary = comic.Summary;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Comics");
        }

        public ActionResult Edit(int? id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
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
            var comicsViewModel = new ComicsViewModel();
            comicsViewModel.Comics = _context.Comics;

            return View(comicsViewModel);
        }

        public ActionResult Details(int? id)
        {
            if(id == null || id < 1)
            {
                return HttpNotFound();
            }

            var comic = _context.Comics.SingleOrDefault(x => x.Id == id);
           
            return View(comic);
           
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
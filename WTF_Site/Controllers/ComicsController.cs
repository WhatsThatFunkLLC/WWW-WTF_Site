using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WTF_Site.Models;
using WTF_Site.Services;
using WTF_Site.ViewModels;

namespace WTF_Site.Controllers
{
    public class ComicsController : Controller
    {
        private IComicService _comicService;

        public ComicsController()
        {
            _comicService = new ComicService();
        }

        // GET: Comics
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var comicsViewModel = new ComicsViewModel();
            comicsViewModel.Comics = _comicService.InitializeComics();

            return View(comicsViewModel);
        }

        public ActionResult Random()
        {
            var comic = new Comic() { Title = "Xybermporphs Volume 1" };
            return View(comic);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}
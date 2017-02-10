using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WTF_Site.Models;

namespace WTF_Site.Controllers
{
    public class ComicsController : Controller
    {
        // GET: Comics
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
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
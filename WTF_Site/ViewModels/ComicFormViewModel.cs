using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTF_Site.Models;

namespace WTF_Site.ViewModels
{
    public class ComicFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Comic Comic { get; set; }
    }
}
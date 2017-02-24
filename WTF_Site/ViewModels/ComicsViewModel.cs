using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WTF_Site.Models;

namespace WTF_Site.ViewModels
{
    public class ComicsViewModel
    {
        public IEnumerable<Comic> Comics;
    }
}
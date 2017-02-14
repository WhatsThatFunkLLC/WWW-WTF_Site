using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WTF_Site.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public double Price { get; set; }
        //public Image Preview { get; set; }
    }
}
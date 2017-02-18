using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTF_Site.Models;

namespace WTF_Site.Services
{
    public interface IComicService
    {
        List<Comic> InitializeComics();
        void SortComics();
        void FilterComics();
    }
}
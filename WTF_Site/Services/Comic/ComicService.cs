using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WTF_Site.Models;

namespace WTF_Site.Services
{
    public class ComicService : IComicService
    {
        public void FilterComics()
        {
            throw new NotImplementedException();
        }

        public List<Comic> InitializeComics()
        {
            List<Comic> comics = new List<Comic>();

            var comic = new Comic();
            comic.Id = 1;
            comic.Price = 3;
            comic.Summary = "Test Comic Summary 1";
            comic.Title = "Xybermorphs issue #1";

            comics.Add(comic);

            var comic2 = new Comic();
            comic2.Id = 2;
            comic2.Price = 4;
            comic2.Summary = "Test Comic Summary 2";
            comic2.Title = "Xybermorphs issue #2";

            comics.Add(comic2);

            return comics;
        }

        public void SortComics()
        {
            throw new NotImplementedException();
        }
    }
}